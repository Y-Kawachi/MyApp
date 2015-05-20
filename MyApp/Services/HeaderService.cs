using MyApp.Models.Entity;
using MyApp.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace MyApp.Services
{
    public class HeaderService
    {
        private readonly IHeaderRepository _repository;

        // default constructor -> HeaderRpository
        public HeaderService()
            : this(new HeaderRepository())
        {
        }

        public HeaderService(IHeaderRepository repository)
        {
            _repository = repository;
        }

        // Queryableによる検索
        public ICollection<Header> Search(Header condition)
        {
            return _repository.Search(condition);
        }

        // IDと一致するレコードを取得
        public Header Find(int? id)
        {
            return _repository.Find(id);
        }

        // データ追加
        public void Add(Header header)
        {
            _repository.Add(header);
        }

        // データ削除
        public void Delete(Header header)
        {
            _repository.Delete(header);
        }

        // データ保存
        public void SaveChanges()
        {
            _repository.SaveChanges();
        }

    }
}
