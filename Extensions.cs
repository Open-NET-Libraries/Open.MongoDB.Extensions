using MongoDB.Driver;
using System;

namespace Open.MongoDB.Extensions
{
    public static class Extensions
    {
		public static MongoClient Client(this MongoClientSettings settings)
			=> new MongoClient(settings);

		public static MongoClient Client(this MongoUrl url)
			=> new MongoClient(url);
	}
}
