using System;
using System.Linq;
using System.Threading.Tasks;
using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using BlazorGrpc;
using BlazorGrpc2;
using Stellinity2.UnitTracker.Shared;

namespace UnitTracker.Service.Services
{
    public class UnitTrackerServiceImplementation : UnitTrackerService.UnitTrackerServiceBase
    {

        public override Task<CheckInCodeReply> GetCheckInCode(Empty request, ServerCallContext context)
        {
            var reply = new CheckInCodeReply();

            var rng = new Random();
            reply.CheckInCode = rng.Next(99999).ToString();

            return Task.FromResult(reply);
        }
    }
}
