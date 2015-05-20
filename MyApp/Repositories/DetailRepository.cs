using MyApp.Models.Entity;
using System.Collections.Generic;
using System.Linq;

namespace MyApp.Repositories
{
    public class DetailRepository : IDetailRepository
    {   
	    public DetailRepository()
	    {

	    }
        // 検索
        public ICollection<Detail> Search(Detail detail)
        {
            return null;
        }

        // IDと一致するレコードを取得
        public Detail Find(int id)
        {
            return null;
        }

        // データ追加
        public void Add(Detail detail)
        {
        }

        // データ削除
        public void Delete(Detail detail)
        { 
        }

        // データ保存
        public void SaveChanges()
        {
        }

    }
}
