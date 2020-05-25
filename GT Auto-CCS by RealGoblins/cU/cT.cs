using System;
using System.ComponentModel;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace cU
{
	// Token: 0x02000013 RID: 19
	public class cT
	{
		// Token: 0x06000085 RID: 133
		[DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto, SetLastError = true)]
		private static extern int SetWindowsHookEx(int ez, cT.Ns eA, IntPtr eB, int eC);

		// Token: 0x06000086 RID: 134
		[DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto, SetLastError = true)]
		private static extern int UnhookWindowsHookEx(int eE);

		// Token: 0x06000087 RID: 135
		[DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto)]
		private static extern int CallNextHookEx(int eG, int eH, int eI, IntPtr eJ);

		// Token: 0x06000088 RID: 136
		[DllImport("user32")]
		private static extern int ToAscii(int eL, int eM, byte[] eN, byte[] eO, int eP);

		// Token: 0x06000089 RID: 137
		[DllImport("user32")]
		private static extern int GetKeyboardState(byte[] eR);

		// Token: 0x0600008A RID: 138
		[DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto)]
		private static extern short GetKeyState(int eT);

		// Token: 0x0600008B RID: 139 RVA: 0x000056B4 File Offset: 0x000038B4
		public cT()
		{
			this.eU();
		}

		// Token: 0x0600008C RID: 140 RVA: 0x000056C4 File Offset: 0x000038C4
		public cT(bool InstallMouseHook, bool InstallKeyboardHook)
		{
			this.eU(InstallMouseHook, InstallKeyboardHook);
		}

		// Token: 0x0600008D RID: 141 RVA: 0x000056D4 File Offset: 0x000038D4
		~cT()
		{
			this.eX(true, true, false);
		}

		// Token: 0x14000001 RID: 1
		// (add) Token: 0x0600008E RID: 142 RVA: 0x00005704 File Offset: 0x00003904
		// (remove) Token: 0x0600008F RID: 143 RVA: 0x0000573C File Offset: 0x0000393C
		public event MouseEventHandler dz
		{
			[CompilerGenerated]
			add
			{
				MouseEventHandler mouseEventHandler = this.OnMouseActivity;
				MouseEventHandler mouseEventHandler2;
				do
				{
					mouseEventHandler2 = mouseEventHandler;
					MouseEventHandler value2 = (MouseEventHandler)Delegate.Combine(mouseEventHandler2, value);
					mouseEventHandler = Interlocked.CompareExchange<MouseEventHandler>(ref this.OnMouseActivity, value2, mouseEventHandler2);
				}
				while (mouseEventHandler != mouseEventHandler2);
			}
			[CompilerGenerated]
			remove
			{
				MouseEventHandler mouseEventHandler = this.OnMouseActivity;
				MouseEventHandler mouseEventHandler2;
				do
				{
					mouseEventHandler2 = mouseEventHandler;
					MouseEventHandler value2 = (MouseEventHandler)Delegate.Remove(mouseEventHandler2, value);
					mouseEventHandler = Interlocked.CompareExchange<MouseEventHandler>(ref this.OnMouseActivity, value2, mouseEventHandler2);
				}
				while (mouseEventHandler != mouseEventHandler2);
			}
		}

		// Token: 0x14000002 RID: 2
		// (add) Token: 0x06000090 RID: 144 RVA: 0x00005774 File Offset: 0x00003974
		// (remove) Token: 0x06000091 RID: 145 RVA: 0x000057AC File Offset: 0x000039AC
		public event MouseEventHandler dE
		{
			[CompilerGenerated]
			add
			{
				MouseEventHandler mouseEventHandler = this.OnMouseActivity_LeftUp;
				MouseEventHandler mouseEventHandler2;
				do
				{
					mouseEventHandler2 = mouseEventHandler;
					MouseEventHandler value2 = (MouseEventHandler)Delegate.Combine(mouseEventHandler2, value);
					mouseEventHandler = Interlocked.CompareExchange<MouseEventHandler>(ref this.OnMouseActivity_LeftUp, value2, mouseEventHandler2);
				}
				while (mouseEventHandler != mouseEventHandler2);
			}
			[CompilerGenerated]
			remove
			{
				MouseEventHandler mouseEventHandler = this.OnMouseActivity_LeftUp;
				MouseEventHandler mouseEventHandler2;
				do
				{
					mouseEventHandler2 = mouseEventHandler;
					MouseEventHandler value2 = (MouseEventHandler)Delegate.Remove(mouseEventHandler2, value);
					mouseEventHandler = Interlocked.CompareExchange<MouseEventHandler>(ref this.OnMouseActivity_LeftUp, value2, mouseEventHandler2);
				}
				while (mouseEventHandler != mouseEventHandler2);
			}
		}

		// Token: 0x14000003 RID: 3
		// (add) Token: 0x06000092 RID: 146 RVA: 0x000057E4 File Offset: 0x000039E4
		// (remove) Token: 0x06000093 RID: 147 RVA: 0x0000581C File Offset: 0x00003A1C
		public event MouseEventHandler dJ
		{
			[CompilerGenerated]
			add
			{
				MouseEventHandler mouseEventHandler = this.OnMouseActivity_LeftDown;
				MouseEventHandler mouseEventHandler2;
				do
				{
					mouseEventHandler2 = mouseEventHandler;
					MouseEventHandler value2 = (MouseEventHandler)Delegate.Combine(mouseEventHandler2, value);
					mouseEventHandler = Interlocked.CompareExchange<MouseEventHandler>(ref this.OnMouseActivity_LeftDown, value2, mouseEventHandler2);
				}
				while (mouseEventHandler != mouseEventHandler2);
			}
			[CompilerGenerated]
			remove
			{
				MouseEventHandler mouseEventHandler = this.OnMouseActivity_LeftDown;
				MouseEventHandler mouseEventHandler2;
				do
				{
					mouseEventHandler2 = mouseEventHandler;
					MouseEventHandler value2 = (MouseEventHandler)Delegate.Remove(mouseEventHandler2, value);
					mouseEventHandler = Interlocked.CompareExchange<MouseEventHandler>(ref this.OnMouseActivity_LeftDown, value2, mouseEventHandler2);
				}
				while (mouseEventHandler != mouseEventHandler2);
			}
		}

		// Token: 0x14000004 RID: 4
		// (add) Token: 0x06000094 RID: 148 RVA: 0x00005854 File Offset: 0x00003A54
		// (remove) Token: 0x06000095 RID: 149 RVA: 0x0000588C File Offset: 0x00003A8C
		public event MouseEventHandler dO
		{
			[CompilerGenerated]
			add
			{
				MouseEventHandler mouseEventHandler = this.OnMouseActivity_Up;
				MouseEventHandler mouseEventHandler2;
				do
				{
					mouseEventHandler2 = mouseEventHandler;
					MouseEventHandler value2 = (MouseEventHandler)Delegate.Combine(mouseEventHandler2, value);
					mouseEventHandler = Interlocked.CompareExchange<MouseEventHandler>(ref this.OnMouseActivity_Up, value2, mouseEventHandler2);
				}
				while (mouseEventHandler != mouseEventHandler2);
			}
			[CompilerGenerated]
			remove
			{
				MouseEventHandler mouseEventHandler = this.OnMouseActivity_Up;
				MouseEventHandler mouseEventHandler2;
				do
				{
					mouseEventHandler2 = mouseEventHandler;
					MouseEventHandler value2 = (MouseEventHandler)Delegate.Remove(mouseEventHandler2, value);
					mouseEventHandler = Interlocked.CompareExchange<MouseEventHandler>(ref this.OnMouseActivity_Up, value2, mouseEventHandler2);
				}
				while (mouseEventHandler != mouseEventHandler2);
			}
		}

		// Token: 0x14000005 RID: 5
		// (add) Token: 0x06000096 RID: 150 RVA: 0x000058C4 File Offset: 0x00003AC4
		// (remove) Token: 0x06000097 RID: 151 RVA: 0x000058FC File Offset: 0x00003AFC
		public event MouseEventHandler dT
		{
			[CompilerGenerated]
			add
			{
				MouseEventHandler mouseEventHandler = this.OnMouseActivity_Down;
				MouseEventHandler mouseEventHandler2;
				do
				{
					mouseEventHandler2 = mouseEventHandler;
					MouseEventHandler value2 = (MouseEventHandler)Delegate.Combine(mouseEventHandler2, value);
					mouseEventHandler = Interlocked.CompareExchange<MouseEventHandler>(ref this.OnMouseActivity_Down, value2, mouseEventHandler2);
				}
				while (mouseEventHandler != mouseEventHandler2);
			}
			[CompilerGenerated]
			remove
			{
				MouseEventHandler mouseEventHandler = this.OnMouseActivity_Down;
				MouseEventHandler mouseEventHandler2;
				do
				{
					mouseEventHandler2 = mouseEventHandler;
					MouseEventHandler value2 = (MouseEventHandler)Delegate.Remove(mouseEventHandler2, value);
					mouseEventHandler = Interlocked.CompareExchange<MouseEventHandler>(ref this.OnMouseActivity_Down, value2, mouseEventHandler2);
				}
				while (mouseEventHandler != mouseEventHandler2);
			}
		}

		// Token: 0x14000006 RID: 6
		// (add) Token: 0x06000098 RID: 152 RVA: 0x00005934 File Offset: 0x00003B34
		// (remove) Token: 0x06000099 RID: 153 RVA: 0x0000596C File Offset: 0x00003B6C
		public event MouseEventHandler dY
		{
			[CompilerGenerated]
			add
			{
				MouseEventHandler mouseEventHandler = this.OnMouseActivity_Move;
				MouseEventHandler mouseEventHandler2;
				do
				{
					mouseEventHandler2 = mouseEventHandler;
					MouseEventHandler value2 = (MouseEventHandler)Delegate.Combine(mouseEventHandler2, value);
					mouseEventHandler = Interlocked.CompareExchange<MouseEventHandler>(ref this.OnMouseActivity_Move, value2, mouseEventHandler2);
				}
				while (mouseEventHandler != mouseEventHandler2);
			}
			[CompilerGenerated]
			remove
			{
				MouseEventHandler mouseEventHandler = this.OnMouseActivity_Move;
				MouseEventHandler mouseEventHandler2;
				do
				{
					mouseEventHandler2 = mouseEventHandler;
					MouseEventHandler value2 = (MouseEventHandler)Delegate.Remove(mouseEventHandler2, value);
					mouseEventHandler = Interlocked.CompareExchange<MouseEventHandler>(ref this.OnMouseActivity_Move, value2, mouseEventHandler2);
				}
				while (mouseEventHandler != mouseEventHandler2);
			}
		}

		// Token: 0x14000007 RID: 7
		// (add) Token: 0x0600009A RID: 154 RVA: 0x000059A4 File Offset: 0x00003BA4
		// (remove) Token: 0x0600009B RID: 155 RVA: 0x000059DC File Offset: 0x00003BDC
		public event MouseEventHandler ed
		{
			[CompilerGenerated]
			add
			{
				MouseEventHandler mouseEventHandler = this.OnMouseActivity_Wheel;
				MouseEventHandler mouseEventHandler2;
				do
				{
					mouseEventHandler2 = mouseEventHandler;
					MouseEventHandler value2 = (MouseEventHandler)Delegate.Combine(mouseEventHandler2, value);
					mouseEventHandler = Interlocked.CompareExchange<MouseEventHandler>(ref this.OnMouseActivity_Wheel, value2, mouseEventHandler2);
				}
				while (mouseEventHandler != mouseEventHandler2);
			}
			[CompilerGenerated]
			remove
			{
				MouseEventHandler mouseEventHandler = this.OnMouseActivity_Wheel;
				MouseEventHandler mouseEventHandler2;
				do
				{
					mouseEventHandler2 = mouseEventHandler;
					MouseEventHandler value2 = (MouseEventHandler)Delegate.Remove(mouseEventHandler2, value);
					mouseEventHandler = Interlocked.CompareExchange<MouseEventHandler>(ref this.OnMouseActivity_Wheel, value2, mouseEventHandler2);
				}
				while (mouseEventHandler != mouseEventHandler2);
			}
		}

		// Token: 0x14000008 RID: 8
		// (add) Token: 0x0600009C RID: 156 RVA: 0x00005A14 File Offset: 0x00003C14
		// (remove) Token: 0x0600009D RID: 157 RVA: 0x00005A4C File Offset: 0x00003C4C
		public event EventHandler<cT.MQ> ei
		{
			[CompilerGenerated]
			add
			{
				EventHandler<cT.MQ> eventHandler = this.OnMouseActivity_Raw;
				EventHandler<cT.MQ> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<cT.MQ> value2 = (EventHandler<cT.MQ>)Delegate.Combine(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler<cT.MQ>>(ref this.OnMouseActivity_Raw, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
			[CompilerGenerated]
			remove
			{
				EventHandler<cT.MQ> eventHandler = this.OnMouseActivity_Raw;
				EventHandler<cT.MQ> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<cT.MQ> value2 = (EventHandler<cT.MQ>)Delegate.Remove(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler<cT.MQ>>(ref this.OnMouseActivity_Raw, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
		}

		// Token: 0x14000009 RID: 9
		// (add) Token: 0x0600009E RID: 158 RVA: 0x00005A84 File Offset: 0x00003C84
		// (remove) Token: 0x0600009F RID: 159 RVA: 0x00005ABC File Offset: 0x00003CBC
		public event KeyEventHandler en
		{
			[CompilerGenerated]
			add
			{
				KeyEventHandler keyEventHandler = this.KeyDown;
				KeyEventHandler keyEventHandler2;
				do
				{
					keyEventHandler2 = keyEventHandler;
					KeyEventHandler value2 = (KeyEventHandler)Delegate.Combine(keyEventHandler2, value);
					keyEventHandler = Interlocked.CompareExchange<KeyEventHandler>(ref this.KeyDown, value2, keyEventHandler2);
				}
				while (keyEventHandler != keyEventHandler2);
			}
			[CompilerGenerated]
			remove
			{
				KeyEventHandler keyEventHandler = this.KeyDown;
				KeyEventHandler keyEventHandler2;
				do
				{
					keyEventHandler2 = keyEventHandler;
					KeyEventHandler value2 = (KeyEventHandler)Delegate.Remove(keyEventHandler2, value);
					keyEventHandler = Interlocked.CompareExchange<KeyEventHandler>(ref this.KeyDown, value2, keyEventHandler2);
				}
				while (keyEventHandler != keyEventHandler2);
			}
		}

		// Token: 0x1400000A RID: 10
		// (add) Token: 0x060000A0 RID: 160 RVA: 0x00005AF4 File Offset: 0x00003CF4
		// (remove) Token: 0x060000A1 RID: 161 RVA: 0x00005B2C File Offset: 0x00003D2C
		public event KeyPressEventHandler es
		{
			[CompilerGenerated]
			add
			{
				KeyPressEventHandler keyPressEventHandler = this.KeyPress;
				KeyPressEventHandler keyPressEventHandler2;
				do
				{
					keyPressEventHandler2 = keyPressEventHandler;
					KeyPressEventHandler value2 = (KeyPressEventHandler)Delegate.Combine(keyPressEventHandler2, value);
					keyPressEventHandler = Interlocked.CompareExchange<KeyPressEventHandler>(ref this.KeyPress, value2, keyPressEventHandler2);
				}
				while (keyPressEventHandler != keyPressEventHandler2);
			}
			[CompilerGenerated]
			remove
			{
				KeyPressEventHandler keyPressEventHandler = this.KeyPress;
				KeyPressEventHandler keyPressEventHandler2;
				do
				{
					keyPressEventHandler2 = keyPressEventHandler;
					KeyPressEventHandler value2 = (KeyPressEventHandler)Delegate.Remove(keyPressEventHandler2, value);
					keyPressEventHandler = Interlocked.CompareExchange<KeyPressEventHandler>(ref this.KeyPress, value2, keyPressEventHandler2);
				}
				while (keyPressEventHandler != keyPressEventHandler2);
			}
		}

		// Token: 0x1400000B RID: 11
		// (add) Token: 0x060000A2 RID: 162 RVA: 0x00005B64 File Offset: 0x00003D64
		// (remove) Token: 0x060000A3 RID: 163 RVA: 0x00005B9C File Offset: 0x00003D9C
		public event KeyEventHandler ex
		{
			[CompilerGenerated]
			add
			{
				KeyEventHandler keyEventHandler = this.KeyUp;
				KeyEventHandler keyEventHandler2;
				do
				{
					keyEventHandler2 = keyEventHandler;
					KeyEventHandler value2 = (KeyEventHandler)Delegate.Combine(keyEventHandler2, value);
					keyEventHandler = Interlocked.CompareExchange<KeyEventHandler>(ref this.KeyUp, value2, keyEventHandler2);
				}
				while (keyEventHandler != keyEventHandler2);
			}
			[CompilerGenerated]
			remove
			{
				KeyEventHandler keyEventHandler = this.KeyUp;
				KeyEventHandler keyEventHandler2;
				do
				{
					keyEventHandler2 = keyEventHandler;
					KeyEventHandler value2 = (KeyEventHandler)Delegate.Remove(keyEventHandler2, value);
					keyEventHandler = Interlocked.CompareExchange<KeyEventHandler>(ref this.KeyUp, value2, keyEventHandler2);
				}
				while (keyEventHandler != keyEventHandler2);
			}
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x00005BD4 File Offset: 0x00003DD4
		public void eU()
		{
			this.eU(true, true);
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x00005BE0 File Offset: 0x00003DE0
		public void eU(bool eV, bool eW)
		{
			if (this.dr == 0 && eV)
			{
				cT.dt = new cT.Ns(this.fb);
				this.dr = cT.SetWindowsHookEx(14, cT.dt, Marshal.GetHINSTANCE(Assembly.GetExecutingAssembly().GetModules()[0]), 0);
				if (this.dr == 0)
				{
					int lastWin32Error = Marshal.GetLastWin32Error();
					this.eX(true, false, false);
					throw new Win32Exception(lastWin32Error);
				}
			}
			if (this.ds == 0 && eW)
			{
				cT.du = new cT.Ns(this.ff);
				this.ds = cT.SetWindowsHookEx(13, cT.du, Marshal.GetHINSTANCE(Assembly.GetExecutingAssembly().GetModules()[0]), 0);
				if (this.ds == 0)
				{
					int lastWin32Error2 = Marshal.GetLastWin32Error();
					this.eX(false, true, false);
					throw new Win32Exception(lastWin32Error2);
				}
			}
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x00005CAC File Offset: 0x00003EAC
		public void eX()
		{
			this.eX(true, true, true);
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x00005CB8 File Offset: 0x00003EB8
		public void eX(bool eY, bool eZ, bool fa)
		{
			if (this.dr != 0 && eY)
			{
				int num = cT.UnhookWindowsHookEx(this.dr);
				this.dr = 0;
				if (num == 0 && fa)
				{
					throw new Win32Exception(Marshal.GetLastWin32Error());
				}
			}
			if (this.ds != 0 && eZ)
			{
				int num2 = cT.UnhookWindowsHookEx(this.ds);
				this.ds = 0;
				if (num2 == 0 && fa)
				{
					throw new Win32Exception(Marshal.GetLastWin32Error());
				}
			}
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x00005D28 File Offset: 0x00003F28
		private int fb(int fc, int fd, IntPtr fe)
		{
			if (fc >= 0 && (this.OnMouseActivity_Wheel != null || this.OnMouseActivity_Raw != null || this.OnMouseActivity != null || this.OnMouseActivity_LeftUp != null || this.OnMouseActivity_Up != null || this.OnMouseActivity_LeftDown != null || this.OnMouseActivity_Down != null || this.OnMouseActivity_Move != null))
			{
				cT.Nl nl = (cT.Nl)Marshal.PtrToStructure(fe, typeof(cT.Nl));
				MouseButtons mouseButtons = MouseButtons.None;
				short delta = 0;
				switch (fd)
				{
				case 513:
				case 514:
				case 515:
					mouseButtons = MouseButtons.Left;
					break;
				case 516:
				case 517:
				case 518:
					mouseButtons = MouseButtons.Right;
					break;
				case 522:
					delta = (short)(nl.Nm >> 16 & 65535);
					break;
				}
				int clicks = 0;
				if (mouseButtons != MouseButtons.None)
				{
					if (fd != 515)
					{
						if (fd != 518)
						{
							clicks = 1;
							goto IL_D8;
						}
					}
					clicks = 2;
				}
				IL_D8:
				MouseEventArgs e = new MouseEventArgs(mouseButtons, clicks, nl.Nh.MO, nl.Nh.MP, (int)delta);
				cT.MQ e2 = new cT.MQ(fc, fd, fe);
				if (this.OnMouseActivity != null)
				{
					this.OnMouseActivity(this, e);
				}
				if (this.OnMouseActivity_LeftUp != null && fd == 514)
				{
					this.OnMouseActivity_LeftUp(this, e);
				}
				if (this.OnMouseActivity_LeftDown != null && fd == 513)
				{
					this.OnMouseActivity_LeftDown(this, e);
				}
				if (this.OnMouseActivity_Move != null && fd == 512)
				{
					this.OnMouseActivity_Move(this, e);
				}
				if (this.OnMouseActivity_Up != null && (fd == 514 || fd == 517))
				{
					this.OnMouseActivity_Up(this, e);
				}
				if (this.OnMouseActivity_Down != null && (fd == 513 || fd == 516))
				{
					this.OnMouseActivity_Down(this, e);
				}
				if (this.OnMouseActivity_Wheel != null && fd == 522)
				{
					this.OnMouseActivity_Wheel(this, e);
				}
				if (this.OnMouseActivity_Raw != null)
				{
					this.OnMouseActivity_Raw(this, e2);
				}
			}
			return cT.CallNextHookEx(this.dr, fc, fd, fe);
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x00005F38 File Offset: 0x00004138
		private int ff(int fg, int fh, IntPtr fi)
		{
			bool flag = false;
			if (fg >= 0 && (this.KeyDown != null || this.KeyUp != null || this.KeyPress != null))
			{
				cT.Np np = (cT.Np)Marshal.PtrToStructure(fi, typeof(cT.Np));
				if (this.KeyDown != null && (fh == 256 || fh == 260))
				{
					KeyEventArgs keyEventArgs = new KeyEventArgs((Keys)np.Nq);
					this.KeyDown(this, keyEventArgs);
					flag = (flag || keyEventArgs.Handled);
				}
				if (this.KeyPress != null && fh == 256)
				{
					bool flag2 = (cT.GetKeyState(16) & 128) == 128;
					bool keyState = cT.GetKeyState(20) != 0;
					byte[] array = new byte[256];
					cT.GetKeyboardState(array);
					byte[] array2 = new byte[2];
					if (cT.ToAscii(np.Nq, np.Nr, array, array2, np.Nn) == 1)
					{
						char c = (char)array2[0];
						if ((keyState ^ flag2) && char.IsLetter(c))
						{
							c = char.ToUpper(c);
						}
						KeyPressEventArgs keyPressEventArgs = new KeyPressEventArgs(c);
						this.KeyPress(this, keyPressEventArgs);
						flag = (flag || keyPressEventArgs.Handled);
					}
				}
				if (this.KeyUp != null && (fh == 257 || fh == 261))
				{
					KeyEventArgs keyEventArgs2 = new KeyEventArgs((Keys)np.Nq);
					this.KeyUp(this, keyEventArgs2);
					flag = (flag || keyEventArgs2.Handled);
				}
			}
			if (flag)
			{
				return 1;
			}
			return cT.CallNextHookEx(this.ds, fg, fh, fi);
		}

		// Token: 0x0400005B RID: 91
		private const int cV = 14;

		// Token: 0x0400005C RID: 92
		private const int cW = 13;

		// Token: 0x0400005D RID: 93
		private const int cX = 7;

		// Token: 0x0400005E RID: 94
		private const int cY = 2;

		// Token: 0x0400005F RID: 95
		private const int cZ = 512;

		// Token: 0x04000060 RID: 96
		private const int da = 513;

		// Token: 0x04000061 RID: 97
		private const int db = 516;

		// Token: 0x04000062 RID: 98
		private const int dc = 519;

		// Token: 0x04000063 RID: 99
		private const int dd = 514;

		// Token: 0x04000064 RID: 100
		private const int de = 517;

		// Token: 0x04000065 RID: 101
		private const int df = 520;

		// Token: 0x04000066 RID: 102
		private const int dg = 515;

		// Token: 0x04000067 RID: 103
		private const int dh = 518;

		// Token: 0x04000068 RID: 104
		private const int di = 521;

		// Token: 0x04000069 RID: 105
		private const int dj = 522;

		// Token: 0x0400006A RID: 106
		private const int dk = 256;

		// Token: 0x0400006B RID: 107
		private const int dl = 257;

		// Token: 0x0400006C RID: 108
		private const int dm = 260;

		// Token: 0x0400006D RID: 109
		private const int dn = 261;

		// Token: 0x0400006E RID: 110
		private const byte @do = 16;

		// Token: 0x0400006F RID: 111
		private const byte dp = 20;

		// Token: 0x04000070 RID: 112
		private const byte dq = 144;

		// Token: 0x04000071 RID: 113
		[CompilerGenerated]
		private MouseEventHandler OnMouseActivity;

		// Token: 0x04000072 RID: 114
		[CompilerGenerated]
		private MouseEventHandler OnMouseActivity_LeftUp;

		// Token: 0x04000073 RID: 115
		[CompilerGenerated]
		private MouseEventHandler OnMouseActivity_LeftDown;

		// Token: 0x04000074 RID: 116
		[CompilerGenerated]
		private MouseEventHandler OnMouseActivity_Up;

		// Token: 0x04000075 RID: 117
		[CompilerGenerated]
		private MouseEventHandler OnMouseActivity_Down;

		// Token: 0x04000076 RID: 118
		[CompilerGenerated]
		private MouseEventHandler OnMouseActivity_Move;

		// Token: 0x04000077 RID: 119
		[CompilerGenerated]
		private MouseEventHandler OnMouseActivity_Wheel;

		// Token: 0x04000078 RID: 120
		[CompilerGenerated]
		private EventHandler<cT.MQ> OnMouseActivity_Raw;

		// Token: 0x04000079 RID: 121
		[CompilerGenerated]
		private KeyEventHandler KeyDown;

		// Token: 0x0400007A RID: 122
		[CompilerGenerated]
		private KeyPressEventHandler KeyPress;

		// Token: 0x0400007B RID: 123
		[CompilerGenerated]
		private KeyEventHandler KeyUp;

		// Token: 0x0400007C RID: 124
		private int dr;

		// Token: 0x0400007D RID: 125
		private int ds;

		// Token: 0x0400007E RID: 126
		private static cT.Ns dt;

		// Token: 0x0400007F RID: 127
		private static cT.Ns du;

		// Token: 0x02000014 RID: 20
		[StructLayout(LayoutKind.Sequential)]
		private class MN
		{
			// Token: 0x04000080 RID: 128
			public int MO;

			// Token: 0x04000081 RID: 129
			public int MP;
		}

		// Token: 0x02000015 RID: 21
		public class MQ : EventArgs
		{
			// Token: 0x060000AB RID: 171 RVA: 0x000060D4 File Offset: 0x000042D4
			public MQ(int nC, int wP, IntPtr lP)
			{
				this.MX = nC;
				this.Nb = wP;
				this.Nf = lP;
			}

			// Token: 0x17000015 RID: 21
			// (get) Token: 0x060000AC RID: 172 RVA: 0x000060F4 File Offset: 0x000042F4
			// (set) Token: 0x060000AD RID: 173 RVA: 0x000060FC File Offset: 0x000042FC
			public int MX { get; set; }

			// Token: 0x17000016 RID: 22
			// (get) Token: 0x060000AE RID: 174 RVA: 0x00006108 File Offset: 0x00004308
			// (set) Token: 0x060000AF RID: 175 RVA: 0x00006110 File Offset: 0x00004310
			public int Nb { get; set; }

			// Token: 0x17000017 RID: 23
			// (get) Token: 0x060000B0 RID: 176 RVA: 0x0000611C File Offset: 0x0000431C
			// (set) Token: 0x060000B1 RID: 177 RVA: 0x00006124 File Offset: 0x00004324
			public IntPtr Nf { get; set; }

			// Token: 0x04000082 RID: 130
			[CompilerGenerated]
			private int MR;

			// Token: 0x04000083 RID: 131
			[CompilerGenerated]
			private int MS;

			// Token: 0x04000084 RID: 132
			[CompilerGenerated]
			private IntPtr MT;
		}

		// Token: 0x02000016 RID: 22
		[StructLayout(LayoutKind.Sequential)]
		private class Ng
		{
			// Token: 0x04000085 RID: 133
			public cT.MN Nh;

			// Token: 0x04000086 RID: 134
			public int Ni;

			// Token: 0x04000087 RID: 135
			public int Nj;

			// Token: 0x04000088 RID: 136
			public int Nk;
		}

		// Token: 0x02000017 RID: 23
		[StructLayout(LayoutKind.Sequential)]
		private class Nl
		{
			// Token: 0x04000089 RID: 137
			public cT.MN Nh;

			// Token: 0x0400008A RID: 138
			public int Nm;

			// Token: 0x0400008B RID: 139
			public int Nn;

			// Token: 0x0400008C RID: 140
			public int No;

			// Token: 0x0400008D RID: 141
			public int Nk;
		}

		// Token: 0x02000018 RID: 24
		[StructLayout(LayoutKind.Sequential)]
		private class Np
		{
			// Token: 0x0400008E RID: 142
			public int Nq;

			// Token: 0x0400008F RID: 143
			public int Nr;

			// Token: 0x04000090 RID: 144
			public int Nn;

			// Token: 0x04000091 RID: 145
			public int No;

			// Token: 0x04000092 RID: 146
			public int Nk;
		}

		// Token: 0x02000019 RID: 25
		// (Invoke) Token: 0x060000B6 RID: 182
		private delegate int Ns(int nCode, int wParam, IntPtr lParam);
	}
}
