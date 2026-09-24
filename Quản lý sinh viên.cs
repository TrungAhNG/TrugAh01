using System;
class Program {
    struct SinhVien {
        public string HoTen;
        public double Diem;
    }
    static void Main(string[] args) {
        int n;
        do {
            Console.Write("Nh?p s? l??ng sinh vi那n n (n > 0): ");
            n = int.Parse(Console.ReadLine());
            if (n <= 0) {
                Console.WriteLine("Vui l辰ng nh?p l?i!");
            }
        } while (n <= 0);

        SinhVien[] dsSinhVien = new SinhVien[n];

        // 2. Nh?p th?ng tin (h? t那n v角 ?i?m s?)
        Console.WriteLine("\n Nh?p th?ng tin sinh vi那n ");
        for (int i = 0; i < n; i++) {
            Console.WriteLine($"\nSinh vi那n th? {i + 1}:");
            Console.Write("H? v角 t那n: ");
            dsSinhVien[i].HoTen = Console.ReadLine();

            Console.Write("?i?m s?: ");
            dsSinhVien[i].Diem = double.Parse(Console.ReadLine());
        }
        double tongDiem = 0;
        for (int i = 0; i < n; i++) {
            tongDiem += dsSinhVien[i].Diem;
        }
        double diemTrungBinhLop = tongDiem / n;
        double diemMax = dsSinhVien[0].Diem;
        for (int i = 1; i < n; i++) {
            if (dsSinhVien[i].Diem > diemMax) {
                diemMax = dsSinhVien[i].Diem;
            }
        }
        int soLuongDat = 0;
        for (int i = 0; i < n; i++) {
            if (dsSinhVien[i].Diem >= 5.0) {
                soLuongDat++;
            }
        }
        Console.WriteLine("\n Danh s芍ch sinh vi那n ");
        Console.WriteLine("{0,-5} | {0,-25} | {0,-10}", "STT", "H? v角 T那n", "?i?m");
        for (int i = 0; i < n; i++) {
            Console.WriteLine($"{i + 1,-5} | {dsSinhVien[i].HoTen,-25} | {dsSinhVien[i].Diem,-10:F2}");
        }
        Console.WriteLine($"\n-> ?i?m trung b足nh c? l?p: {diemTrungBinhLop:F2}");
        Console.WriteLine($"-> ?i?m cao nh?t l?p (Max): {diemMax:F2}");
        Console.WriteLine("   C芍c sinh vi那n ??t ?i?m Max:");
        for (int i = 0; i < n; i++) {
            if (dsSinhVien[i].Diem == diemMax) {
                Console.WriteLine($"   - {dsSinhVien[i].HoTen}");
            }
        }
        Console.WriteLine($"-> S? l??ng sinh vi那n ??t (>= 5.0): {soLuongDat}/{n}");
    }
}