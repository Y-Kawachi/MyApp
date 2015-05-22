using MyApp.Models;
using MyApp.Models.Entity;
using System.Collections.Generic;
using System.Linq;

namespace MyApp.Repositories
{
    public class HeaderRepository : IHeaderRepository
    {
        private readonly MyContext _context = new MyContext();

	    public HeaderRepository()
	    {

	    }

        // 検索
        public ICollection<Header> Search(Header condition )
        {
            var query = from h in _context.Headers 
                        select h;

            condition = condition ?? new Header();

            if (condition.Id != 0)
            {
                query = query.Where(h => h.Id == condition.Id);
            }

            if (!string.IsNullOrEmpty(condition.Title))
            {
                query = query.Where(h => h.Title.Contains(condition.Title));
            }

            return query.OrderBy(h => h.Id).ToList();
        }

        // IDと一致するレコードを取得
        public Header Find(int? id)
        {
            if (id == null) throw new KeyNotFoundException();

            return _context.Headers.Find(id);
        }

        // データ追加
        public void Add(Header header)
        {
            _context.Headers.Add(header);
        }

        // データ削除
        public void Delete(Header header)
        {
            _context.Headers.Remove(header);
        }

        // データ保存
        public void SaveChanges()
        {
            _context.SaveChanges();
        }

    }
}
