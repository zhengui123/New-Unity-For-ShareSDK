//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18408
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
namespace cn.sharesdk.unity3d
{
	/// <summary>
	/// Platform type.
	/// </summary>
	public enum PlatformType
	{
		Unknown = 0,
		SinaWeibo = 1,			//Sina Weibo         
		TencentWeibo = 2,		//Tencent Weibo          
		DouBan = 5,				//Dou Ban           
		QZone = 6, 				//QZone           
		Renren = 7,				//Ren Ren           
		Kaixin = 8,				//Kai Xin          
		Pengyou = 9,			//Friends          
		Facebook = 10,			//Facebook         
		Twitter = 11,			//Twitter         
		Evernote = 12,			//Evernote        
		Foursquare = 13,		//Foursquare      
		GooglePlus = 14,		//Google+       
		Instagram = 15,			//Instagram      
		LinkedIn = 16,			//LinkedIn       
		Tumblr = 17,			//Tumblr         
		Mail = 18, 				//Mail          
		SMS = 19,				//SMS           
		Print = 20, 			//Print       
		Copy = 21,				//Copy             
		WeChat = 22,		    //WeChat Friends    
		WeChatMoments = 23,	    //WeChat WechatMoments   
		QQ = 24,				//QQ              
		Instapaper = 25,		//Instapaper       
		Pocket = 26,			//Pocket           
		YouDaoNote = 27, 		//You Dao Note           
		Pinterest = 30, 		//Pinterest    
		Flickr = 34,			//Flickr          
		Dropbox = 35,			//Dropbox          
		VKontakte = 36,			//VKontakte       
		WeChatFavorites = 37,	//WeChat Favorited        
		YiXinSession = 38, 		//YiXin Session   
		YiXinTimeline = 39,		//YiXin Timeline   
		YiXinFav = 40,			//YiXin Favorited  
		MingDao = 41,          	//明道
		Line = 42,             	//Line
		WhatsApp = 43,         	//Whats App
		KakaoTalk = 44,         //KakaoTalk
		KakaoStory = 45,        //KakaoStory 
		FacebookMessenger = 46, //FacebookMessenger
		Bluetooth = 48,         //Bluetooth
		AliSocial = 50,            //AliSocial
		AliSocialMoments = 51,     //AliSocialMoments
		Dingding = 52,			//DingTalk 钉钉
		Youtube = 53,			//youtube
		MeiPai = 54,            //美拍

#if UNITY_ANDROID
		KakaoPlatform = 44,    
		EvernoteInternational = 12,
		WechatPlatform = 22,  
		QQPlatform = 24,
		YixinPlatform = 38,
		//Telegram = 47,         //Telegram
        CMCC = 55               //中国移动
       
#elif UNITY_IPHONE
        CMCC = 55               //中国移动
		YixinPlatform = 994,    //Yixin series
		KakaoPlatform = 995,    //Kakao series
		EvernoteInternational = 996,//Evernote InternationaL Edition
		WechatPlatform = 997,   //Wechat Series
		QQPlatform = 998,		//QQ Series  
#endif

    }

}

