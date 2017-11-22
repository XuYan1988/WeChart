using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WZAutoEye.WZAutoEyeMVC.Model
{
    /// <summary>
    /// �ļ�˵��: �û���ɫ����Ϣʵ��
    /// ��    ��: Ԭ����
    /// ��������: 2017��08��17��
    /// ����ģ��: CTSR.Template.Model.MVC_Model_01 ��
    /// �ر�˵�������ļ��ɴ������ɹ����Զ����ɣ����������޸ģ�
    /// </summary>
    [Serializable]
    public partial class MUserRole
    {
        [Key]
        public Guid UserRoleID { get; set; }
 
        [DisplayName("��ɫID")]
        public Nullable<Guid> RoleID { get; set; }
 
        [DisplayName("�û�ID")]
        public Nullable<Guid> UserID { get; set; }
 
        [DisplayName("�˿�CD")]
        public string PortCD { get; set; }
 
        public virtual MRole RoleID_FK { get; set; }
        public virtual MUser UserID_FK { get; set; }
        public virtual MPort PortCD_FK { get; set; }
    }
}