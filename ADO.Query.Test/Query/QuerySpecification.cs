﻿
namespace ADO.Query.Test.Query
{
    using System.Collections.Generic;

    using ADO.Query.Mapper;
    using ADO.Query.SqlQuery;
    using ADO.Query.Test.Query.Dto;

    public class QuerySpecification : ISqlSpecification<IEnumerable<SimpleDto>>
    {
        public QuerySpecification()
        {
            this.Expression = "select...";
        }

        public IEnumerable<SimpleDto> MapResult(IQueryMappers mapper, dynamic source)
        {
            return (source != null) ? mapper.MapDynamicToList<SimpleDto>(source) : null;
        }

        public string Expression { get; private set; }
        public IDictionary<string, object> Parameters { get; private set; }
    }
}
