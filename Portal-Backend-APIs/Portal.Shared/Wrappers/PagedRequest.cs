using System;
using System.Collections.Generic;
using System.Text;

namespace Portal.Shared.Wrappers
{
    public class PagedRequest
    {
        private const int MaxPageSize = 100;

        private int _pageSize = 20;

        public int PageNumber { get; set; } = 1;

        public int PageSize
        {
            get => _pageSize;
            set => _pageSize = value is < 1 or > MaxPageSize ? _pageSize : value;
        }

        public string? SortBy { get; set; }
        public bool SortDescending { get; set; }
        public string? SearchTerm { get; set; }
    }
}
