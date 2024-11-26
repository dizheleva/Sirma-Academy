namespace HotelRoomReservationSystem
{
    using System.Collections.Generic;

    public class Hotel
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public List<Receptionist> Receptionists { get; private set; }
        public List<Room> Rooms { get; private set; }
        public IGerente Gerente { get; private set; }

        public Hotel(string name)
        {
            Name = name;
            Receptionists = new List<Receptionist>();
            Rooms = new List<Room>();
        }

        public Hotel(string nome, string address)
        {
            Name = nome;
            Address = address;
            Receptionists = new List<Receptionist>();
            Rooms = new List<Room>();
        }

        public void ContratarGerente(IGerente gerente)
        {
            Gerente = gerente;
        }

        public void AddRoom(Room room)
        {
            Rooms.Add(room);
        }

        public void AddReceptionist(Receptionist receptionist)
        {
            Receptionists.Add(receptionist);
        }
    }
}
