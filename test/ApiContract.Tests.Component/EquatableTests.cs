using OwnApt.Api.Contract.Model;
using OwnApt.Common.Enum;
using System;
using System.Collections.Generic;
using Xunit;

namespace ApiContract.Tests.Component
{
    public class EquatableTests
    {
        #region Public Methods

        [Fact]
        public void CanEquatePropertyModels()
        {
            var addressModel = Random.AddressModel;
            var features = Random.FeaturesModel;
            var id = Random.String;
            var ownerIds = new List<string> { Random.String };
            var tenantIds = new List<string> { Random.String };
            var propertyType = Random.PropertyType;

            var orig = new PropertyModel
            {
                Address = addressModel,
                Features = features,
                Id = id,
                OwnerIds = ownerIds,
                PropertyType = propertyType,
                TenantIds = tenantIds
            };

            var copy = new PropertyModel
            {
                Address = addressModel,
                Features = features,
                Id = id,
                OwnerIds = ownerIds,
                PropertyType = propertyType,
                TenantIds = tenantIds
            };

            Assert.Equal(orig, copy);
        }

        [Fact]
        public void CannotEquateUnequalPropertyModels()
        {
            var orig = new PropertyModel
            {
                Address = Random.AddressModel,
                Features = Random.FeaturesModel,
                Id = Random.String,
                OwnerIds = new List<string> { Random.String },
                PropertyType = PropertyType.Duplex,
                TenantIds = new List<string> { Random.String }
            };

            var copy = new PropertyModel
            {
                Address = Random.AddressModel,
                Features = Random.FeaturesModel,
                Id = Random.String,
                OwnerIds = new List<string> { Random.String },
                PropertyType = PropertyType.Duplex,
                TenantIds = new List<string> { Random.String }
            };

            Assert.NotEqual(orig, copy);
        }

        #endregion Public Methods
    }

    internal static class Random
    {
        #region Internal Properties

        internal static AddressModel AddressModel => new AddressModel
        {
            Address1 = Random.String,
            Address2 = Random.String,
            City = Random.String,
            County = Random.String,
            State = Random.State,
            Zip = Random.ZipModel
        };

        internal static AmenityModel AmenityModel => new AmenityModel
        {
            Type = Random.String,
            Description = Random.String
        };

        internal static FeaturesModel FeaturesModel => new FeaturesModel
        {
            Ammentities = new List<AmenityModel> { Random.AmenityModel, Random.AmenityModel, Random.AmenityModel },
            Bathrooms = Random.Int,
            Levels = Random.Int,
            Parking = new List<ParkingModel> { Random.ParkingModel, Random.ParkingModel, Random.ParkingModel },
            Rooms = Random.Int
        };

        internal static int Int => new System.Random().Next();

        internal static ParkingModel ParkingModel => new ParkingModel
        {
            Type = Random.String,
            Description = Random.String
        };

        internal static PropertyType PropertyType => (PropertyType)new System.Random().Next(3);
        internal static State State => (State)new System.Random().Next(50);
        internal static string String => Guid.NewGuid().ToString();

        internal static ZipModel ZipModel => new ZipModel
        {
            Base = Random.String,
            Extension = Random.String
        };

        #endregion Internal Properties
    }
}
