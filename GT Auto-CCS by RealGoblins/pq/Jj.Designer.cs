namespace pq
{
	// Token: 0x02000073 RID: 115
	public partial class Jj : global::System.Windows.Forms.Form
	{
		// Token: 0x060003DA RID: 986 RVA: 0x00023368 File Offset: 0x00021568
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.oL != null)
			{
				this.oL.Dispose();
			}
			base.Dispose(disposing);
			global::System.Windows.Forms.Application.DoEvents();
		}

		// Token: 0x04000302 RID: 770
		private global::System.ComponentModel.IContainer oL;
	}
}
