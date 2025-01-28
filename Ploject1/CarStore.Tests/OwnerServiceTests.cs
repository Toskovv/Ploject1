using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarStore.BL.Services;
using CarStore.DL.Repositories;
using CarStore.Models.DTO;
using Moq;
using Xunit;
namespace CarStore.Tests
{
    public class OwnerServiceTests
    {
        [Fact]
        public void CreateOwner_ValidOwner_AddsOwner()
        {
            var mockRepo = new Mock<IOwnerRepository>();
            var service = new OwnerService(mockRepo.Object);

            var owner = new Owner { Name = "John", Email = "john@example.com" };

            service.CreateOwner(owner);

            mockRepo.Verify(r => r.AddOwner(It.IsAny<Owner>()), Times.Once);
        }
    }
}