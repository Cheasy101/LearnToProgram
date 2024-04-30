using Application.Constants;
using Application.Interfaces;
using Contracts.Requests;
using Contracts.Requests.Auth.PostResetPassword;
using Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Identity;

namespace Application.Features.Commands.Auth.PostResetPassword;

public class PostResetPasswordCommandHandler(UserManager<User> userManager,
    IEmailSender emailSender)
    : IRequestHandler<PostResetPasswordCommand, PostResetPasswordResponse>
{
    public async Task<PostResetPasswordResponse> Handle(PostResetPasswordCommand request, CancellationToken cancellationToken)
    {
        var response = new PostResetPasswordResponse { IsSuccessful = false };

        var user = await userManager.FindByEmailAsync(request.Email);

        if (user is null)
        {
            response.ErrorMessages.Add(new ResponseErrorMessageItem(nameof(request.Email),
                AuthErrorMessages.UserWithThisEmailNotFound));
            return response;
        }
        
        var token = await userManager.GeneratePasswordResetTokenAsync(user);
        var confirmLink = BaseUrls.ConfirmPasswordResetLink(token, user.Email!);
        
        await emailSender.SendEmailAsync(user.Email!,
            AuthEmailMessages.ResetPasswordConfirmMessage(user.UserName!, confirmLink), cancellationToken);

        response.IsSuccessful = true;
        return response;
    }
}