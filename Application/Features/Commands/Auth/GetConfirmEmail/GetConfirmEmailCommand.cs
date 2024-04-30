using Contracts.Requests.Auth.GetConfirmEmail;
using MediatR;

namespace Application.Features.Commands.Auth.GetConfirmEmail;

public class GetConfirmEmailCommand(GetConfirmEmailRequest? request)
    : GetConfirmEmailRequest(request),
        IRequest<GetConfirmEmailResponse>;