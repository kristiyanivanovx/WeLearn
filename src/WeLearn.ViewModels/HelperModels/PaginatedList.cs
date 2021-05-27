using System;
using System.Collections.Generic;
using System.Linq;
using WeLearn.Data.Models.Enums;

namespace WeLearn.ViewModels.HelperModels
{
    public class PaginatedList<T> : List<T>
    {
		public Grade Grade { get; set; }

		public string SearchString { get;  set; }
        
        public string CategoryName { get; set; }

        public int PageIndex { get; private set; }

        public int TotalPages { get; private set; }

        public PaginatedList(List<T> items, int count, int pageIndex, int pageSize)
        {
            PageIndex = pageIndex;
            TotalPages = (int) Math.Ceiling(count / (double) pageSize);
            this.AddRange(items);
        }

        public bool HasPreviousPage => (PageIndex > 1);

        public bool HasNextPage => (PageIndex < TotalPages);

        public static PaginatedList<T> Create(IEnumerable<T> source, int pageIndex, int pageSize)
        {
            var count = source.Count();
            var items = source.Skip((pageIndex - 1) * pageSize).Take(pageSize).ToList();
            return new PaginatedList<T>(items, count, pageIndex, pageSize);
        }
    }
}
