﻿using System;

namespace WiproDay6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hotel htl = new Hotel();
            IEnumerable<RoomAC> result = htl.GetAll();

            foreach (RoomAC r in result)
            {
                Console.WriteLine(r.RoomNo + " " + r.RoomType + " " + r.Price);
            }

            htl.AddRoom(new RoomAC() { RoomNo = 115, RoomType = "Double", Price = 8000 });

            IEnumerable<RoomNonAC> resultn = ((IRoom<RoomNonAC>)htl).GetAll();

            foreach (RoomNonAC r in resultn)
            {
                Console.WriteLine(r.RoomNo + " " + r.RoomType + " " + r.Price);
            }


            htl.AddRoom(new RoomNonAC() { RoomNo = 115, RoomType = "Double", Price = 8000 });
        }
    }
}