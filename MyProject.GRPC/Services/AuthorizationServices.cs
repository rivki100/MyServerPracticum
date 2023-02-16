using Grpc.Core;
using MyProject.Common.DTOs;
using MyProject.Services.Interface;

namespace MyProject.GRPC.Services
{
    public class AuthorizationServices:Authorization.AuthorizationBase
    {
        private readonly IClaimService _claimService;
        private readonly IHmoService _hmoService;
        public AuthorizationServices(IClaimService claimService,IHmoService hmoService)
        {
            _claimService = claimService;
            _hmoService = hmoService; 
        }
        public override async Task<AuthorizationReply> CheckAccess(AuthorizationRequest request, ServerCallContext context)
        {
            AuthorizationReply reply=new AuthorizationReply { Allow=false};
            int perId=0;
            var hmo = await _hmoService.GetAllAsync();
            foreach (var h in hmo)
            {
                if(h.Name == request.Hmo)
                    perId = h.Id;
            }
            var claims = await _claimService.GetAllAsync();
            foreach (var claim in claims)
            {
                if(claim.HmoId==perId && claim.UserId == request.UserId) 
                    reply.Allow = true;
            }
            return await Task.FromResult(reply);
        }
    }
}
