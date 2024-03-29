﻿using MongoDB.Driver;


namespace projetoBlog.Models
{
    public class AcessoMongoDB
    {
        public const string STRING_DE_CONEXAO = "mongodb://localhost:27017";
        public const string NOME_DA_BASE = "Blog";
        public const string NOME_DA_COLECAO_PUBLICACAO = "Publicacoes";
        public const string NOME_DA_COLECAO_USUARIO = "Usuarios";

        private static readonly IMongoClient _client;
        private static readonly IMongoDatabase _database;

        static AcessoMongoDB()
        {
            _client = new MongoClient(STRING_DE_CONEXAO);
            _database = _client.GetDatabase(NOME_DA_BASE);
        }

        public IMongoClient Client
        {
            get { return _client; }
        }
        public IMongoCollection<Usuario> Usuarios
        {
            get { return _database.GetCollection<Usuario>(NOME_DA_COLECAO_USUARIO); }
        }
        public IMongoCollection<Publicacao> Publicacoes
        {
            get { return _database.GetCollection<Publicacao>(NOME_DA_COLECAO_PUBLICACAO); }
        }
    }
}
