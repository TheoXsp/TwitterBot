using System;
using System.IO;
using Tweetinvi;
using Tweetinvi.Models;
using Tweetinvi.Parameters;
using System.Threading.Tasks;

namespace RightOnTime
{
    class Program
    {
        static async Task Main(string[] args)
        {
            string APIKey = "QiUyoFJxMgWwYeJsM3gAfFEqF";
            string APISecret = "QpadUDPMCYb25z0OeqSTW0Rv8Gso6HRGw9cCabdrx5vdrgtHKq";
            string AccessToken = "3424713424-1w4qrR6vTA94xgv8ZMPImJlMFOh4v6VfnZzD0OJ";
            string AccessSecret = "cK2twGcC31aRXa5Ex4kkWZdOTRK1Iox8bQFAA31FhmjNx";
            byte[] ImageBytes = File.ReadAllBytes("elonn.jpg");

            TwitterClient Userclient = new TwitterClient(APIKey, APISecret, AccessToken, AccessSecret);
            IMedia ImageImedia = await Userclient.Upload.UploadTweetImageAsync(ImageBytes);
            ITweet TweetWithImage = await Userclient.Tweets.PublishTweetAsync(new PublishTweetParameters() { Medias = { ImageImedia } });
        }
    }
}
