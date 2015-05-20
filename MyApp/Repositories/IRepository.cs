using System.Collections.Generic;

namespace MyApp.Repositories
{
    public interface IRepository<T>
    {
        // 検索
        ICollection<T> Search(T t);

        // IDと一致するレコードを取得
        T Find(int? id);

        // データ追加
        void Add(T t);

        // データ削除
        void Delete(T t);

        // データ保存
        void SaveChanges();
    }
}
