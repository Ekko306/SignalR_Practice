using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RazorPagesMovie.Data;
using RazorPagesMovie.Models;

namespace RazorPagesMovie.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly RazorPagesMovie.Data.RazorPagesMovieContext _context;

        public IndexModel(RazorPagesMovie.Data.RazorPagesMovieContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; }

        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }  // SearchString 搜索时输入的字文本，有 BindProperty属性 绑定 属性相同的表单值的查询字符串
        public SelectList Genres { get; set; } // 流派列表 从列表选择 SelectList 的需要 Rendering包

        [BindProperty(SupportsGet = true)]
        public string MovieGenre { get; set; } // 包含用户选择的特定流派 例如 "Western"

        public async Task OnGetAsync()
        {
            IQueryable<string> genreQuery = from m in _context.Movie
                                            orderby m.Genre
                                            select m.Genre;  // 查询数据库总的所有流派
            var movies = from m in _context.Movie    // 创建 LINQ查询选择电影
                         select m;
            if (!string.IsNullOrEmpty(SearchString))   // 不为null或空 就修改为根据字符串筛选
            {
                movies = movies.Where(s => s.Title.Contains(SearchString));
            }

            if (!string.IsNullOrEmpty(MovieGenre))
            {
                movies = movies.Where(x => x.Genre == MovieGenre);
            }
            Genres = new SelectList(await genreQuery.Distinct().ToListAsync());   // 流派的select通过投影不包含重复值的流派创建
            Movie = await movies.ToListAsync();
        }
    }
}
