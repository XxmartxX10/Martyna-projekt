// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
void sortujBabelkowo(int[] tablicaLiczb)
{
    for (int i = 0; i < tablicaLiczb.Length; i++)
    {
        for (int j = i + 1; j < tablicaLiczb.Length; j++)
        {
            if (tablicaLiczb[i] > tablicaLiczb[j])
            {
                int temp = tablicaLiczb[i];

                tablicaLiczb[i] = tablicaLiczb[j];

                tablicaLiczb[j] = temp;
            }
        }
    }
}
private void BtnSortowanieB_Click(object sender, EventArgs e)
{
    txtCiagB.Clear();

    int[] kopiaDlaSortowaniaBabelkowego = (int[])tablicaLiczb.Clone();

    sortujBabelkowo(kopiaDlaSortowaniaBabelkowego);

    txtCiagB.Text = string.Join(" ", kopiaDlaSortowaniaBabelkowego);

}
