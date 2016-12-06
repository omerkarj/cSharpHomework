using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Web;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace Ex01.FacebookClient
{
    public enum ePostExposureType
    {
        Everyone,
        Friends,
        OnlyMe
    }

    public class LogicService
    {
        private User m_LoggedInUser;

        public User Login()
        {
            LoginResult result = FacebookService.Login("225454867885514",
                "public_profile",
                "user_education_history",
                "user_birthday",
                "user_actions.video",
                "user_actions.news",
                "user_actions.music",
                "user_actions.fitness",
                "user_actions.books",
                "user_about_me",
                "user_friends",
                "publish_actions",
                "user_events",
                "user_games_activity",
                "user_hometown",
                "user_likes",
                "user_location",
                "user_managed_groups",
                "user_photos",
                "user_posts",
                "user_relationships",
                "user_relationship_details",
                "user_religion_politics",
                "user_tagged_places",
                "user_videos",
                "user_website",
                "user_work_history",
                "read_custom_friendlists",
                "read_page_mailboxes",
                "manage_pages",
                "publish_pages",
                "publish_actions",
                "rsvp_event"
                );


            if (!string.IsNullOrEmpty(result.AccessToken))
            {
                m_LoggedInUser = result.LoggedInUser;
                return result.LoggedInUser;
            }
            else
            {
                return null;
            }
        }

        public FacebookObjectCollection<User> GetFriends()
        {
            return m_LoggedInUser.Friends;
        }

        public FacebookObjectCollection<Group> GetGroups()
        {
            return m_LoggedInUser.Groups;
        }

        public FacebookObjectCollection<Page> GetPages()
        {
            return m_LoggedInUser.LikedPages;
        }

        public FacebookObjectCollection<Post> GetFeed()
        {
            return m_LoggedInUser.NewsFeed;
        }

        public List<Checkin> GetCheckinsWithinRange(DateTime i_From, DateTime i_To)
        {
            List<Checkin> checkins = new List<Checkin>();

            foreach (Checkin checkin in m_LoggedInUser.Checkins)
            {
                if (checkin.CreatedTime.Value >= i_From && checkin.CreatedTime.Value <= i_To)
                {
                    checkins.Add(checkin);
                }
            }

            return checkins;
        }

        public void PostOnWall(string i_PostMessage)
        {
            m_LoggedInUser.PostStatus(i_PostMessage);
        }

    }
}