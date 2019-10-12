using System;
using System.Net.Http;
using lab_50_api_todo_list_core; //reference classes from other projects
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace lab_48_read_api
{
    class Program
    {
        static string url = "https://localhost:44391/api/TaskItems/";
        static HttpClient client = new HttpClient();
        static TaskItem taskItem = null;
        static List<TaskItem> taskitems = new List<TaskItem>();

        static void Main(string[] args)
        {
            
            GetTaskItemsAsync().Wait();
            DisplayTaskItems();


            GetTaskItemAsync(1).Wait();
            DisplayTaskItem();

            DeleteTaskItemAsync(taskitem);

            //var t = new TaskItem
            //{
            //    Description = "This is a new Task",
            //    TaskDone = false,
            //    DateDue = DateTime.Parse("12/12/2019"),
            //    UserID = 2,
            //    CategoryID = 3
            //};
            //TaskItem newitem = PostNewTaskItemAsync(t).Result;
            //Console.WriteLine($" new item ID: {newitem.TaskItemID}");
            

        }






        static async Task GetTaskItemsAsync()
        {
            Console.WriteLine("Getting Task Items");
            var response = await client.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                var responseString = await response.Content.ReadAsStringAsync();
                taskitems = JsonConvert.DeserializeObject < List<TaskItem>>(responseString);
            }
            
        }

        static async Task GetTaskItemAsync(int taskitemid)
        {
            Console.WriteLine($"Getting Task Item: {taskitemid}");
            var response = await client.GetAsync(url+taskitemid);
            if (response.IsSuccessStatusCode)
            {
                var responseString = await response.Content.ReadAsStringAsync();
                taskItem = JsonConvert.DeserializeObject<TaskItem>(responseString);
            }

        }

        static async Task<TaskItem> PostNewTaskItemAsync(TaskItem t)
        {
            var taskitemstring = JsonConvert.SerializeObject(t); //as string
            var taskitemhttp = new StringContent(taskitemstring); //as http request
            taskitemhttp.Headers.ContentType.MediaType = "application/json";
            taskitemhttp.Headers.ContentType.CharSet = "UTF-8";
            var response = await client.PostAsync(url, taskitemhttp);
            Console.WriteLine(response.Content);
            var newitemasjson = response.Content.ReadAsStringAsync();
            var newitemastask = JsonConvert.DeserializeObject<TaskItem>(newitemasjson.Result);
            Console.WriteLine(newitemastask.TaskItemID);

            return newitemastask;

        }

        static async Task<TaskItem> DeleteTaskItemAsync(TaskItem i)
        {

            var response = await client.DeleteAsync(url + i);

            var newItemsJson = response.Content.ReadAsStringAsync(); // allows to read the response as a string 
            var itemTaskDeleted = JsonConvert.DeserializeObject<TaskItem>(newItemsJson.Result);// turns response as json
            return itemTaskDeleted; //returns the item task delted

        }

        static async Task<TaskItem> UpdateCustomerAsync(TaskItem i, string d)
        {
            var response = await client.GetAsync(url + i);

            var newItemsJson = response.Content.ReadAsStringAsync();
            var itemTaskDeleted = JsonConvert.DeserializeObject<TaskItem>(newItemsJson.Result);// turns response as json
            return itemTaskDeleted; //returns the item task delted
        }



        static void DisplayTaskItems()
        {
            taskitems.ForEach(t => {
                Console.WriteLine($"{t.TaskItemID, -10}{t.Description, -10}{t.TaskDone, -10}{t.DateDue, -10}");
            });
        }

        static void DisplayTaskItem()
        {
            
                Console.WriteLine($"{taskItem.TaskItemID,-10}{taskItem.Description,-10}{taskItem.TaskDone,-10}{taskItem.DateDue,-10}");
        }
    }
}
