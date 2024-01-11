using System.Collections.ObjectModel;

using AlarmOperator.Models.Interfases;

namespace AlarmOperator.Services.Interfaces
{
	public interface IRepository<T> where T : IEntity
	{
		void Add(T item);
		void Update(int id, T item);
		bool Remove(T item);
		ObservableCollection<T> GetAll();
		T Get(int id);
	}

}
