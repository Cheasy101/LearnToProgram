using Contracts.Requests.Auth.PostResetPassword;
using MediatR;

namespace Application.Features.Commands.Auth.PostResetPassword;

public class PostResetPasswordCommand(PostResetPasswordRequest? request) 
    : PostResetPasswordRequest(request),
        IRequest<PostResetPasswordResponse>;