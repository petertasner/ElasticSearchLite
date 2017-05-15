﻿using ElasticSearchLite.NetCore.Interfaces;

namespace ElasticSearchLite.NetCore.Queries
{
    public class Upsert : AbstractQuery
    {
        public Upsert(IElasticPoco poco) : base(poco) { }
        /// <summary>
        /// Creates an upsert statement for the given poco
        /// It used the Update API 
        /// https://www.elastic.co/guide/en/elasticsearch/reference/5.4/docs-update.html#upserts
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="poco"></param>
        /// <returns></returns>
        public static Upsert Document<T>(T poco)
            where T : IElasticPoco => new Upsert(poco);
    }
}
