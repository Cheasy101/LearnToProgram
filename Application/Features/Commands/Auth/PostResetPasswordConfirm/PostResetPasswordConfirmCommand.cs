using Contracts.Requests.Auth.PostResetPasswordConfirm;
using MediatR;

namespace Application.Features.Commands.Auth.PostResetPasswordConfirm;

public class PostResetPasswordConfirmCommand(PostResetPasswordConfirmRequest? request)
    : PostResetPasswordConfirmRequest(request),
        IRequest<PostResetPasswordConfirmResponse>;