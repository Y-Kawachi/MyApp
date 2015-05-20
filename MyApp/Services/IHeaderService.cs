using MyApp.Models.Entity;
using System.Collections.Generic;

namespace MyApp.Services
{
    interface IHeaderService
    {
        // Queryableによる検索
        ICollection<Header> Search(Header condition);

        // IDと一致するレコードを取得
        Header Find(int id);

        // データ追加
        void Add(Header t);

        // データ削除
        void Delete(Header header);

        // データ保存
        void SaveChanges();
    }
}
