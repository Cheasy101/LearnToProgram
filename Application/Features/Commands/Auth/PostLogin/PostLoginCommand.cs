using Contracts.Requests.Auth.PostLogin;
using MediatR;

namespace Application.Features.Commands.Auth.PostLogin
{
    public class PostLoginCommand(PostLoginRequest request)
        : PostLoginRequest(request),
            IRequest<PostLoginResponse>;
}