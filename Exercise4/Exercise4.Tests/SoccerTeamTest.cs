// <copyright file="SoccerTeamTest.cs">Copyright ©  2017</copyright>
using System;
using Exercise4;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercise4.Tests
{
    /// <summary>This class contains parameterized unit tests for SoccerTeam</summary>
    [PexClass(typeof(SoccerTeam))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class SoccerTeamTest
    {

        /// <summary>Test stub for AddPlayer(SoccerPlayer)</summary>
        [PexMethod]
        internal void AddPlayerTest([PexAssumeUnderTest]SoccerTeam target, SoccerPlayer player)
        {
            target.AddPlayer(player);
            // TODO: add assertions to method SoccerTeamTest.AddPlayerTest(SoccerTeam, SoccerPlayer)
        }
    }
}
