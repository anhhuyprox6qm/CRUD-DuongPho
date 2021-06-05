using System;
using System.Text;
using StreetCRUD.controller;
using StreetCRUD.entity;
using StreetCRUD.model;
using StreetCRUD.view;

namespace StreetCRUD
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            DuongPho duongPho = new DuongPho();
            duongPho.Ma = "A001";
            duongPho.Ten = "Nguyễn Văn Trác";
            duongPho.MoTa = "Dương Nội";
            duongPho.NgaySuDung = DateTime.Now ;
            duongPho.LichSu = "Yên Nghĩa";
            duongPho.TenQuan = "Hà Đông";
            duongPho.TrangThai = 1;
            DuongPhoDbModel duongPhoDbModel = new DuongPhoDbModel();
            duongPhoDbModel.Save(duongPho);
            //để sau đi up git nhé
            //nó bị lỗi phông suwa đc k nhỉ lỗi đâu ?
            // chỉnh đc nhưng để lần sau lúc tạo mới database thì để nó về utf8bm4_unicode_ci là đc uk
            // up git nhé ôk
        }
    }
}