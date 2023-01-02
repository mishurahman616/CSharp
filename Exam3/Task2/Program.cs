// See https://aka.ms/new-console-template for more information
using Task2;

Grid<int> grid = new Grid<int>(10, 10, 10);
grid[0, 0, 0]= 1;
Console.WriteLine(grid[0, 0, 0]);