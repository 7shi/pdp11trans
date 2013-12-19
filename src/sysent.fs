module p11trans.sysent

(* system call number of Unix V6 *)

let getSyscallNumber = function
    | "indir"  -> "0"
    | "exit"   -> "1"
    | "fork"   -> "2"
    | "read"   -> "3"
    | "write"  -> "4"
    | "open"   -> "5"
    | "close"  -> "6"
    | "wait"   -> "7"
    | "creat"  -> "8"
    | "link"   -> "9"
    | "unlink" -> "10"
    | "exec"   -> "11"
    | "chdir"  -> "12"
    | "time"   -> "13"
    | "mknod"  -> "14"
    | "chmod"  -> "15"
    | "chown"  -> "16"
    | "break"  -> "17"
    | "stat"   -> "18"
    | "seek"   -> "19"
    | "getpid" -> "20"
    | "mount"  -> "21"
    | "umount" -> "22"
    | "setuid" -> "23"
    | "getuid" -> "24"
    | "stime"  -> "25"
    | "ptrace" -> "26"
    | "fstat"  -> "28"
    | "smdate" -> "30"
    | "stty"   -> "31"
    | "gtty"   -> "32"
    | "nice"   -> "34"
    | "sleep"  -> "35"
    | "sync"   -> "36"
    | "kill"   -> "37"
    | "switch" -> "38"
    | "dup"    -> "41"
    | "pipe"   -> "42"
    | "times"  -> "43"
    | "prof"   -> "44"
    | "tiu"    -> "45"
    | "setgid" -> "46"
    | "getgid" -> "47"
    | "sig"    -> "48"
    | x -> x
