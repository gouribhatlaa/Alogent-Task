using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Assessment.Web.Models
{
    public interface IBoardRepositoryAssignment
    {
        bool Add(Board board);
        bool Delete(int boardid);// delete a board, which means it will delete both board and the pins assosiated with it

        bool Add(int boardId, List<PostIt> postIts);

        IEnumerable<PostIt> Get(int boardId);

        bool Delete(int boardId, int pinId);

        bool Delete(int boardid, List<PostIt> postIts);// delete a board, and the respective selected pins assosiated with it
        

    }

    public class BoardRepositoryAssignment : IBoardRepositoryAssignment
    {
        private List<Board> boards;

        public BoardRepositoryAssignment()
        {
            boards = GetBoardsFromFile();
        }

        public bool Add(Board board)
        {
            throw new NotImplementedException();
        }

        public bool Add(int boardId, List<PostIt> postIts)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int boardid)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int boardId, int pinId)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int boardid, List<PostIt> postIts)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<PostIt> Get(int boardId)
        {
            throw new NotImplementedException();
        }
        private List<Board> GetBoardsFromFile()
        {
            var filePath = Application.Configuration["DataFile"];
            if (!Path.IsPathRooted(filePath)) filePath = Path.Combine(Directory.GetCurrentDirectory(), filePath);

            var json = System.IO.File.ReadAllText(filePath);

            return JsonConvert.DeserializeObject<List<Board>>(json);
        }
    }
}
