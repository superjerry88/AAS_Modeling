using System;
using System.Collections.Generic;
using System.Text;
using AAS_Modeling.Factory;
using AAS_Modeling.Model.Assets;
using AAS_Modeling.Model.Identifier;
using MongoDB.Bson;
using MongoDB.Driver;

namespace AAS_Modeling.Core
{
    class MongoConnector
    {
    }

    public class MongoHelper
    {
        private const string Url = "mongodb://i2hub.tarc.edu.my:4009";
        private const string DatabaseName = "TestDb";
        private const string AssetCollection = "Asset";
        private const string IraiSubdivisionCollection = "Subdivision";

        public static void CreateAsset(BaseAsset asset)
        {
            var client = new MongoClient(Url);
            var db = client.GetDatabase(DatabaseName);
            var collection = db.GetCollection<BaseAsset>(AssetCollection);
            collection.InsertOne(asset);
        }

        public static BaseAsset GetAsset(string irai)
        {
            var client = new MongoClient(Url);
            var db = client.GetDatabase(DatabaseName);
            var collection = db.GetCollection<BaseAsset>(AssetCollection);
            return collection.AsQueryable().FirstOrDefault();
            //test
        }

        public static void CreateSubdivisionInDb()
        {
            var client = new MongoClient(Url);
            var db = client.GetDatabase(DatabaseName);
            var collection = db.GetCollection<AssetSubdivision>(IraiSubdivisionCollection);
            collection.InsertMany(AssetSubdivisionFactory.GenerateAssetSubdivisions());
        }
    }
}
