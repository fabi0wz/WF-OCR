using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace HermaPicker
{
    internal class UploadHandler
    {
        private HttpListener httpListener;
        private string uploadFolderPath; // Specify the folder path where you want to save the uploaded files

        public UploadHandler(string url, string uploadFolderPath)
        {
            this.httpListener = new HttpListener();
            this.httpListener.Prefixes.Add(url);
            this.uploadFolderPath = uploadFolderPath;
        }

        public void StartListening()
        {
            httpListener.Start();
            Task.Run(async () =>
            {
                while (httpListener.IsListening)
                {
                    try
                    {
                        HttpListenerContext context = await httpListener.GetContextAsync();
                        HandleRequest(context);
                    }
                    catch (Exception ex)
                    {
                        // Handle any exceptions that occur during request handling
                        Console.WriteLine($"Error: {ex.Message}");
                    }
                }
            });
        }

        public void StopListening()
        {
            httpListener.Stop();
            httpListener.Close();
        }

        private void HandleRequest(HttpListenerContext context)
        {
            if (context.Request.HttpMethod == "POST")
            {
                HttpListenerRequest request = context.Request;
                string fileName = request.Headers["FileName"];
                MessageBox.Show(request.Headers.ToString());
                string savePath = Path.Combine(uploadFolderPath, fileName);

                using (FileStream fs = File.Create(savePath))
                {
                    request.InputStream.CopyTo(fs);
                }

                // Handle the uploaded file as needed
                context.Response.StatusCode = (int)HttpStatusCode.OK;
                context.Response.Close();
            }
            else
            {
                context.Response.StatusCode = (int)HttpStatusCode.MethodNotAllowed;
                context.Response.Close();
            }
        }
    }
}
