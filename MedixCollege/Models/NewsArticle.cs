﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MedixCollege.Models
{
    public class NewsArticle
    {
        public NewsArticleDTO NewsArticleDTO { get; set; }
        private bool _connectionOpen;
        private MySqlConnection _connection;

        public NewsArticle()
        {

        }

        public NewsArticle(int id)
        {
            NewsArticleDTO = new NewsArticleDTO();
            NewsArticleDTO.Id = id;

            try
            {
                using (var connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["MySQLConnection"].ConnectionString))
                {
                    connection.Open();

                    using (var command = new MySqlCommand(string.Format("SELECT * FROM NewsArticle WHERE Id = {0}", id), connection))
                    {
                        var reader = command.ExecuteReader();
                        reader.Read();

                        if (reader.IsDBNull(1) == false)
                            NewsArticleDTO.Date = reader.GetDateTime(1);
                        else
                            NewsArticleDTO.Date = DateTime.Now;

                        if (reader.IsDBNull(2) == false)
                            NewsArticleDTO.Title = reader.GetString(2);
                        else
                            NewsArticleDTO.Title = null;

                        if (reader.IsDBNull(3) == false)
                            NewsArticleDTO.Body = reader.GetString(3);
                        else
                            NewsArticleDTO.Body = null;

                        if (reader.IsDBNull(4) == false)
                            NewsArticleDTO.Meta = reader.GetString(4);
                        else
                            NewsArticleDTO.Meta = null;

                        if (reader.IsDBNull(5) == false)
                            NewsArticleDTO.Slug = reader.GetString(5);
                        else
                            NewsArticleDTO.Slug = null;

                        reader.Close();
                    }
                }
            }
            catch (MySqlException e)
            {
                //TODO: log error
            }
        }

        public IList<NewsArticleDTO> Get()
        {
            IList<NewsArticleDTO> newsArticles = new List<NewsArticleDTO>();

            try
            {
                using (var connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["MySQLConnection"].ConnectionString))
                {
                    connection.Open();

                    using (var command = new MySqlCommand(string.Format("SELECT * FROM NewsArticle ORDER BY Id DESC"), connection))
                    {
                        var reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            var newsArticle = new NewsArticleDTO();

                            if (reader.IsDBNull(0) == false)
                                newsArticle.Id = reader.GetInt32(0);
                            else
                                newsArticle.Date = DateTime.Now;

                            if (reader.IsDBNull(1) == false)
                                newsArticle.Date = reader.GetDateTime(1);
                            else
                                newsArticle.Date = DateTime.Now;

                            if (reader.IsDBNull(2) == false)
                                newsArticle.Title = reader.GetString(2);
                            else
                                newsArticle.Title = null;

                            if (reader.IsDBNull(3) == false)
                                newsArticle.Body = reader.GetString(3);
                            else
                                newsArticle.Body = null;

                            if (reader.IsDBNull(4) == false)
                                newsArticle.Meta = reader.GetString(4);
                            else
                                newsArticle.Meta = null;

                            if (reader.IsDBNull(5) == false)
                                newsArticle.Slug = reader.GetString(5);
                            else
                                newsArticle.Slug = null;

                            newsArticles.Add(newsArticle);
                        }
                    }
                }
            }
            catch (MySqlException e)
            {
                //TODO: log error
            }

            return newsArticles;
        }

        private void GetConnection()
        {
            _connectionOpen = false;

            _connection = new MySqlConnection();
            _connection.ConnectionString = ConfigurationManager.ConnectionStrings["MySQLConnection"].ConnectionString;

            if (OpenLocalConnection())
            {
                _connectionOpen = true;
            }
        }

        private bool OpenLocalConnection()
        {
            try
            {
                _connection.Open();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }

    public class NewsArticleDTO
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public string Meta { get; set; }
        public string Slug { get; set; }

        public string GenerateSlug()
        {
            string phrase = string.Format("{0}-{1}", Id, Slug);

            string str = RemoveAccent(phrase).ToLower();
            // invalid chars           
            str = Regex.Replace(str, @"[^a-z0-9\s-]", "");
            // convert multiple spaces into one space   
            str = Regex.Replace(str, @"\s+", " ").Trim();
            // cut and trim 
            str = str.Substring(0, str.Length <= 145 ? str.Length : 145).Trim();
            str = Regex.Replace(str, @"\s", "-"); // hyphens   
            return str;
        }

        private string RemoveAccent(string text)
        {
            byte[] bytes = System.Text.Encoding.GetEncoding("Cyrillic").GetBytes(text);
            return System.Text.Encoding.ASCII.GetString(bytes);
        }
    }
}


  

