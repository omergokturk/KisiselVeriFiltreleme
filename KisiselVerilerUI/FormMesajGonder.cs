using KisiselVeriler.BLL;
using KisiselVeriler.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KisiselVerilerUI
{
    public partial class FormMesajGonder : Form
    {
        #region Field
        List<KisiBilgileriDTO> _kisiBilgileriDTO;
        List<TreeNode> _treeNodesList;
        List<TreeNode> _tiklananTreeNodes;
        List<TreeNode> _secilenTreeNodes;
        HobilerController _hc;
        List<TreeNode> _secilenHobiNodeList;
        #endregion
        public FormMesajGonder()
        {
            _hc = new HobilerController();
            InitializeComponent();
            _treeNodesList = new List<TreeNode>();
            _tiklananTreeNodes = new List<TreeNode>();
            _secilenTreeNodes = new List<TreeNode>();
            _secilenHobiNodeList = new List<TreeNode>();
            _kisiBilgileriDTO = new List<KisiBilgileriDTO>();
        }
        private void FormMesajGonder_Load(object sender, EventArgs e)
        {
            HobiTreeViewListele();
        }
        private void HobiTreeViewListele()
        {
            List<HobilerDTO> hobiler = _hc.HobileriGetir();
            foreach (var hobi in hobiler)
            {
                TreeNode treeNode = new TreeNode();
                treeNode.Text = hobi.HobiAdi;
                treeNode.Tag = hobi.HobiID;
                trvHobiler.Nodes.Add(treeNode);

                List<HobilerDTO> altHobiler = _hc.AltHobileriGetir(hobi.HobiID);
                foreach (var altHobi in altHobiler)
                {
                    TreeNode altTreeNode = new TreeNode();
                    altTreeNode.Text = altHobi.HobiAdi;
                    altTreeNode.Tag = altHobi.HobiID;
                    treeNode.Nodes.Add(altTreeNode);
                }
            }
        }
        private void trvHobiler_AfterExpand(object sender, TreeViewEventArgs e)
        {

            //e.Node.Checked = true;
            if (!_treeNodesList.Contains(e.Node))
            {
                _treeNodesList.Add(e.Node);
                TreeNode expandedNode = e.Node;
                foreach (TreeNode node in expandedNode.Nodes)
                {

                    try
                    {
                        List<HobilerDTO> altHobiler = _hc.AltHobileriGetir((int)node.Tag);
                        foreach (var altHobi in altHobiler)
                        {
                            TreeNode altNode = new TreeNode();
                            altNode.Text = altHobi.HobiAdi;
                            altNode.Tag = altHobi.HobiID;
                            node.Nodes.Add(altNode);
                        }
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                }
            }


        }
        private void trvHobiler_AfterCheck(object sender, TreeViewEventArgs e)
        {
            dgvKisiBilgileri.DataSource = null;
            _kisiBilgileriDTO.Clear();
            List<int> tiklananNodeIDleri = new List<int>();
            if (e.Node.Checked == true)
            {
                _secilenHobiNodeList.Add(e.Node);
            }
            else
            {
                _secilenHobiNodeList.Remove(e.Node);
            }
            foreach (var secilenHobiID in _secilenHobiNodeList)
            {
                tiklananNodeIDleri.Add((int)secilenHobiID.Tag);
            }
            foreach (var tiklananNode in tiklananNodeIDleri)
            {
                SecilenHobininKisiniGetir(tiklananNode);
            }
        }
        private void SecilenHobininKisiniGetir(int hobiID)
        {
            dgvKisiBilgileri.DataSource = null;
            foreach (var itemKisiDTO in _hc.HobiIDdenKisiGetir(hobiID))
            {
                _kisiBilgileriDTO.Add(itemKisiDTO);
            }
            dgvKisiBilgileri.DataSource = _kisiBilgileriDTO;
        }



        private void dgvKisiBilgileri_DoubleClick(object sender, EventArgs e)
        {

            string[] stringDizi = { dgvKisiBilgileri.CurrentRow.Cells[1].Value.ToString(),
                                       dgvKisiBilgileri.CurrentRow.Cells[2].Value.ToString(),
                                       dgvKisiBilgileri.CurrentRow.Cells[3].Value.ToString(),
                                            dgvKisiBilgileri.CurrentRow.Cells[12].Value.ToString(),
                                                dgvKisiBilgileri.CurrentRow.Cells[13].Value.ToString()};
            ListViewItem listViewItem = new ListViewItem(stringDizi);
            listView1.Items.Add(listViewItem);


            textBox1.Text = textBox1.Text + dgvKisiBilgileri.CurrentRow.Cells[13].Value.ToString();
            textBox1.Text = textBox1.Text + ",";

            
        }

        private void btnMesaj_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Telefon Numaralarına Mesaj Gönderildi..");
        }
    }
}
