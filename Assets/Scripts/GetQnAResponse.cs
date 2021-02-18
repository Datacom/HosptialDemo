using System;
using System.Linq;
using System.Net.Http;
using System.Text;
using UnityEngine;


public class GetQnAResponse : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }    

    public string GetQnAAnswer(string text)
    {
        //Uri uri = new UriBuilder("https://unityva-dc-dev-ae-qna.azurewebsites.net/qnamaker/knowledgebases/c11a5fc9-e3b8-471e-808e-5ac850774b2f/generateAnswer").Uri;
        //JObject paramsContent = new JObject();
        //paramsContent.Add("question", text);
        //paramsContent.Add("top", 1);
        //paramsContent.Add("rankerType", "QuestionOnly");
        //try
        //{
        //    using (HttpClient client = new HttpClient())
        //    {
        //        using (var request = new HttpRequestMessage(HttpMethod.Post, uri)
        //        {
        //            Headers = { { "Authorization", "EndpointKey 60fa9991-7ae0-4132-b4f0-3642a21debb3" } },
        //            Content = new StringContent(paramsContent.ToString(), Encoding.UTF8, "application/json")
        //        })
        //        {
        //            using (var response = client.SendAsync(request).Result)
        //            {
        //                response.EnsureSuccessStatusCode();
        //                var responseStr = response.Content.ReadAsStringAsync().Result;
        //                var root = JObject.Parse(responseStr);
        //                JArray answers = (JArray)JObject.Parse(root.ToString())["answers"];
        //                var answer = answers.FirstOrDefault();
        //                if (answer["answer"].ToString() != null)
        //                    return answer["answer"].ToString();
        //                else
        //                    return "Sorry, I don't understand you question, please ask again";
        //            }
        //    }
        //    }
        //}
        //catch (Exception ex)
        //{
        //    throw new Exception(ex.Message);
        //}
        return null;
    }
}
