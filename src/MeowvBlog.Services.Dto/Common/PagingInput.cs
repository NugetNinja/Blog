﻿namespace MeowvBlog.Services.Dto.Common
{
    /// <summary>
    /// 分页输入参数
    /// </summary>
    public class PagingInput
    {
        /// <summary>
        /// 当前开始页
        /// </summary>
        public int PageIndex { get; set; } = 1;

        /// <summary>
        /// 页大小
        /// </summary>
        public int PageSize { get; set; } = 20;
    }
}