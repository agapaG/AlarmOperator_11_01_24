using System;
using System.Linq;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using AlarmOperator.Models.Interfases;
using AlarmOperator.Services.Interfaces;

namespace AlarmOperator.Services.Base
{
	internal abstract class RepositoryInMemory<T> : IRepository<T> where T : IEntity
	{
		private ObservableCollection<T> _Items = new ObservableCollection<T>();

		private int _LastId = -1;

		protected RepositoryInMemory() { }

		protected RepositoryInMemory(IEnumerable<T> items)
		{
			foreach (var item in items)
			{
				Add(item);
			}
		}

		public void Add(T item)
		{
			if (item == null)
				throw new ArgumentNullException(nameof(item));

			if (_Items.Contains(item)) return;

			item.Id = ++_LastId;

			_Items.Add(item);
		}

		public ObservableCollection<T> GetAll() => _Items;

		public T Get(int id) => GetAll().FirstOrDefault(item => item.Id == id);


		public bool Remove(T item) => _Items.Remove(item);

		public void Update(int id, T item)
		{
			if (item == null)
				throw new ArgumentNullException(nameof(item));

			if (id < 0)
				throw new ArgumentOutOfRangeException(nameof(id), id, "Индекс не может быть меньше 0");

			if (_Items.Contains(item)) return;

			var db_item = ((IRepository<T>)this).Get(id);
			if (db_item == null)
				throw new InvalidOperationException("Редактируемый элемент не найден в репозитории");

			//Обновление элемента - задача клиентов
			Update(item, db_item);
		}

		protected abstract void Update(T Source, T Destination);
	}
}
