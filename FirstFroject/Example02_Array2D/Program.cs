using System;

namespace Example02_Array2D
{
    internal class Program
    {
        // 0 은 갈수 있는 길 , 1은 벽
        static int[,] map = new int[5, 5]
        {
            { 0, 0, 0, 0, 1 },
            { 0, 1, 1, 1, 1 },
            { 0, 0, 0, 1 ,1 },
            { 1, 1, 0, 0, 0 },
            { 0, 1, 1, 0, 0 }
        };
        static void Main(string[] args)
        {
            Player player = new Player();
            player.x = 3;
            player.y = 0;
            player.MoveLeft(map);
        }
    }

    class Player
    {
        public int x; // 현재 x 좌표
        public int y; // 현재 y 좌표

        /// <summary>
        /// 플레이어를 현재 맵에서 왼쪽으로 이동시키는 함수
        /// </summary>
        /// <param name="map"> 이동시킬 기준이 되는 맵 </param>
        public void MoveLeft(int[,] map)
        {
            // 이동하려는 위치가 맵의 경계를 넘어가는지 체크
            if (x - 1 < 0)
            {
                Console.WriteLine($"플레이어를 왼쪽으로 이동시킬 수 없습니다. (맵의 경계)");
            }
            // 이동하려는 위치가 이동가능하면 이동
            else if (map[y, x - 1] == 0)
            {
                x--;
                Console.WriteLine($"플레이어 왼쪽으로 한칸 이동. 현재 위치 {x}, {y}");
            }
            // 이동하려는 위치가 벽이면 이동안함
            else if (map[y, x - 1] == 1)
            {
                Console.WriteLine($"플레이어를 왼쪽으로 이동시킬 수 없습니다. (벽)");
            }
        }

        public void MoveRight(int[,] map)
        {
            // 이동하려는 위치가 맵의 경계를 넘어가는지 체크
            if (x + 1 > map.GetLength(1) - 1)
            {
                Console.WriteLine($"플레이어를 오른쪽으로 이동시킬 수 없습니다. (맵의 경계)");
            }
            // 이동하려는 위치가 이동가능하면 이동
            else if (map[y, x + 1] == 0)
            {
                x++;
                Console.WriteLine($"플레이어 오른쪽으로 한칸 이동. 현재 위치 {x}, {y}");
            }
            // 이동하려는 위치가 벽이면 이동안함
            else if (map[y, x + 1] == 1)
            {
                Console.WriteLine($"플레이어를 오른쪽으로 이동시킬 수 없습니다. (벽)");
            }
        }

        public void MoveUp(int[,] map)
        {
            // 이동하려는 위치가 맵의 경계를 넘어가는지 체크
            if (y - 1 < 0)
            {
                Console.WriteLine($"플레이어를 위쪽으로 이동시킬 수 없습니다. (맵의 경계)");
            }
            // 이동하려는 위치가 이동가능하면 이동
            else if (map[y - 1, x] == 0)
            {
                y--;
                Console.WriteLine($"플레이어 위쪽으로 한칸 이동. 현재 위치 {x}, {y}");
            }
            // 이동하려는 위치가 벽이면 이동안함
            else if (map[y - 1, x] == 1)
            {
                Console.WriteLine($"플레이어를 위쪽으로 이동시킬 수 없습니다. (벽)");
            }
        }

        public void MoveDown(int[,] map)
        {
            // 이동하려는 위치가 맵의 경계를 넘어가는지 체크
            if (y + 1 > map.GetLength(0) - 1)
            {
                Console.WriteLine($"플레이어를 아랫쪽으로 이동시킬 수 없습니다. (맵의 경계)");
            }
            // 이동하려는 위치가 이동가능하면 이동
            else if (map[y + 1, x] == 0)
            {
                y++;
                Console.WriteLine($"플레이어 아랫쪽으로 한칸 이동. 현재 위치 {x}, {y}");
            }
            // 이동하려는 위치가 벽이면 이동안함
            else if (map[y + 1, x] == 1)
            {
                Console.WriteLine($"플레이어를 아랫쪽으로 이동시킬 수 없습니다. (벽)");
            }
        }
    }
}