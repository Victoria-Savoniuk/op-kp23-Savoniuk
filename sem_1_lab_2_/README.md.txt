Programming. C#. Sem1. Assignment 2.

����������. 
������ ���������� �������, �� ����������� � ��������� ����������� ����������� � ��������� ��������: ��� ������ �������� �� ���� ���������, ��� ���������� ������� ���� ����������� ����������? 
��� ����������� ����� �������� ��������� ����������� ������, ������ �� ����������.

������. 
� ������ ��������� ������������ �������, �������������� ������� n �� n. 
����� ������ ������� - ������� ��� �����������. ����� ������ � �� ������� ������, ��� 璺����� � �������� ������� � ��������� ����� ����� �������� ������ (����, ������, �����, ����) �������� ������. 
������� � ����������, ���� � �������� ����� � ����� ������. 

��� ����� ��� ����������� ����������. 
��� ����������� ������� ����������, ������� ��� ����� Percolation �� ����� ��������:

���������� ����. �� ������ ������� � ������������� ����.

class Percolation {

    // creates n-by-n grid, with all sites initially blocked
    static void init(int n)

    // opens the site (row, col) if it is not open already
    static void open(int row, int col)

    // is the site (row, col) open?
    static boolean isOpen(int row, int col)

    // is the site (row, col) full?
    static boolean isFull(int row, int col)

    // returns the number of open sites
    static int numberOfOpenSites()

    // does the system percolate?
    static boolean percolates()

    // prints the matrix on the screen
    // The method should display different types of sites (open, blocked, full)
    static void print()

    // test client (optional)
    static static void main(String[] args)
}

�������. 
�����: 1 <= i <= n, �������: 1 <= j <= n

������ �� �������������. 
����� ����������� ������� ������������ �� ���, ������������ O(n^2); 
�� ������ ����� ������������ �� ����������� ��� + ������� ������� ������� union() � find().

� ������������ ������� ������� ��������� ���-����� ��� ��� ������� � ������, �� ��������������� � ����������� �����.




