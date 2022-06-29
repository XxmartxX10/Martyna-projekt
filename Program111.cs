// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
void sortujQuicksort(int[] tablicaLiczb, int L, int R)
{
    int i = L;
    int j = R;
    int pv = tablicaLiczb[(L + R) / 2];

    while (i <= j)
    {
        while (tablicaLiczb[i] < pv)
            i++;
        while (tablicaLiczb[j] > pv)
            j--;

        if (i <= j)
        {
            int tmp = tablicaLiczb[i];
            tablicaLiczb[i++] = tablicaLiczb[j];
            tablicaLiczb[j--] = tmp;
        }
    }
    if (j > L)
    {
        sortujQuicksort(tablicaLiczb, L, j);
    }
    if (i < R)
    {
        sortujQuicksort(tablicaLiczb, i, R);
    }
}
private void BtnSortowanieQ_Click(object sender, EventArgs e)
{
    txtCiagQ.Clear();

    int[] kopiaDlaSortowania = (int[])tablicaLiczb.Clone();

    sortujQuicksort(kopiaDlaSortowania, 0, kopiaDlaSortowania.Length - 1);

    txtCiagQ.Text = string.Join(" ", kopiaDlaSortowania);
}