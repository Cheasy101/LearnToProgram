using Application.Constants;
using Contracts.Requests;
using Contracts.Requests.Auth.PostLogin;
using Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Identity;

namespace Application.Features.Commands.Auth.PostLogin;

public class PostLoginCommandHandler(UserManager<User> userManager, SignInManager<User> signInManager)
    : IRequestHandler<PostLoginCommand, PostLoginResponse>
{
    public async Task<PostLoginResponse> Handle(PostLoginCommand request, CancellationToken cancellationToken)
    {
        var response = new PostLoginResponse {IsSuccessful = false};
        
        var user = await userManager.FindByEmailAsync(request.Email);

        if (user is null)
        {
            response.ErrorMessages.Add(new ResponseErrorMessageItem(nameof(request.Email),
                AuthErrorMessages.UserWithThisEmailNotFound));
            return response;
        }

        var signInResult = await signInManager.PasswordSignInAsync(user, request.Password,
            request.RememberMe, false);

        if (!signInResult.Succeeded)
        {
            response.ErrorMessages.Add(new ResponseErrorMessageItem(nameof(request.Password),
                AuthErrorMessages.WrongPassword));
            return response;
        }

        response.IsSuccessful = true;
        return response;
    }
}