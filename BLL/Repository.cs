using BLL.Connection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Repository
{
    public class Repository<T>
    {
        public IQueryable<T> GetAll(string requestUri)
        {
            var response = GlobalConnection.WebApiClient.GetAsync(requestUri).Result;
            if (!response.IsSuccessStatusCode)
                throw new Exception(response.ToString());
            var list = response.Content.ReadAsAsync<IEnumerable<T>>().Result;
            return list.AsQueryable();
        }


        public T GetById(string requestUri, int? id)
        {
            var response = GlobalConnection.WebApiClient.GetAsync(requestUri + "/" + id).Result;
            if (!response.IsSuccessStatusCode)
                throw new Exception(response.ToString());
            var result = response.Content.ReadAsAsync<T>().Result;
            return result;
        }

        public T GetById(string requestUri, string stringId)
        {
            var response = GlobalConnection.WebApiClient.GetAsync(requestUri + "/" + stringId).Result;
            if (!response.IsSuccessStatusCode)
                throw new Exception(response.ToString());
            var result = response.Content.ReadAsAsync<T>().Result;
            return result;
        }


        public T GetById(string requestUri, long stringId, string id)
        {
            var response = GlobalConnection.WebApiClient.GetAsync(requestUri + "/" + stringId + "/"+ id.ToString()).Result;
            if (!response.IsSuccessStatusCode)
                throw new Exception(response.ToString());
            var result = response.Content.ReadAsAsync<T>().Result;
            return result;
        }
        public void Edit(string requestUri, T target, int id)
        {
            var response = GlobalConnection.WebApiClient.PutAsJsonAsync(requestUri + "/" + id, target).Result;
            if (!response.IsSuccessStatusCode)
                throw new Exception(response.ToString());
        }

        public T Save(string requestUri, T target)
        {
            var response = GlobalConnection.WebApiClient.PostAsJsonAsync(requestUri, target).Result;
            if (!response.IsSuccessStatusCode)
                throw new Exception(response.ToString());
            return response.Content.ReadAsAsync<T>().Result;
        }

        public List<T> SaveCollection(string requestUri, List<T> list)
        {
            var targetList = new List<T>();
            foreach (var target in list)
            {
                var response = GlobalConnection.WebApiClient.PostAsJsonAsync(requestUri, target).Result;
                if (!response.IsSuccessStatusCode)
                {
                    throw new Exception(response.ToString());
                }
                targetList.Add(response.Content.ReadAsAsync<T>().Result);
            }
            return targetList;
        }

        public void Delete(string requestUri, int? id)
        {
            var response = GlobalConnection.WebApiClient.DeleteAsync(requestUri + "/" + id).Result;
            if (!response.IsSuccessStatusCode)
                throw new Exception(response.ToString());
        }
    }
}
