﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;

namespace ControlZone.ViewModels.ViewModelPages
{
    public class ViewModelMainPage : ViewModelBase
    {
        private ObservableCollection<Room> rooms;
        public ObservableCollection<Room> Rooms
        {
            get { return rooms; }
            set
            {
                rooms = value;
                OnPropertyChanged();
            }
        }
        private ObservableCollection<Tool> tools;
        public ObservableCollection<Tool> Tools
        {
            get { return tools; }
            set
            {
                tools = value;
                OnPropertyChanged();
            }
        }
        private ObservableCollection<User> users;
        public ObservableCollection<User> Users
        {
            get { return users; }
            set
            {
                users = value;
                OnPropertyChanged();
            }
        }
        private ObservableCollection<User> GetUsers()
        {
            return new ObservableCollection<User>
            {
                new User { userID=1, userName="Long" , userAge=20}
            };
        }
        private ObservableCollection<Tool> GetTools()
        {
            return new ObservableCollection<Tool>
            {
                new Tool { toolName="Thực đơn", color = Color.Green, image = "FoodO"},
                new Tool { toolName="Nhân viên", color = Color.Blue, image = "UserO" },
                new Tool { toolName="Vật dụng", color = Color.Orange, image = "UtilitiesO"},
                new Tool { toolName="Công Việc", color = Color.Gray, image = "JobO"},
                new Tool { toolName="Đơn hàng", color = Color.Yellow, image = "PaperO"}
            };
        }
        private ObservableCollection<Room> GetRooms()
        {
            return new ObservableCollection<Room>
            {
                new Room { roomID=1, roomName="Tiếp Tân", roomColor="#eff3ff", fontColor="#576a90", roomIcon="DiningRoom2B"},
                new Room { roomID=2, roomName="Phòng Khách 1", roomColor="#fd7449", fontColor="#576a90", roomIcon="CoffeeRoomB"},
                new Room { roomID=3, roomName="Phòng Khách 2", roomColor="#eff3ff", fontColor="#576a90", roomIcon="CoffeeRoomB"},
                new Room { roomID=4, roomName="Phòng Khách 3", roomColor="#fd7449", fontColor="#576a90", roomIcon="CoffeeRoomB"},
                new Room { roomID=5, roomName="Nhà vệ sinh", roomColor="#eff3ff", fontColor="#576a90", roomIcon="ToiletB"},
                new Room { roomID=6, roomName="phòng nhân viên", roomColor="#fd7449", fontColor="#576a90", roomIcon="EmployeeRoomB"}
            };
        }
        public ViewModelMainPage()
        {
            Tools = GetTools();
            Users = GetUsers();
            Rooms = GetRooms();
        }
    }
}
