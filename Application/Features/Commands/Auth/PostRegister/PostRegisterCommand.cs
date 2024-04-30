using Contracts.Requests.Auth.PostRegister;
using MediatR;

namespace Application.Features.Commands.Auth.PostRegister;

public class PostRegisterCommand(PostRegisterRequest? request)
    : PostRegisterRequest(request), 
        IRequest<PostRegisterResponse>;