using System;

namespace UserAccountControlEnumerations
{
   /// <summary>
   /// Flags that control the behavior of the user account.
   /// </summary>
   [Flags]
   public enum UserAccountControl
   {
      /// <summary>
      /// The logon script is executed.
      ///</summary>
      SCRIPT = 1 << 0,

      /// <summary>
      /// The user account is disabled.
      ///</summary>
      ACCOUNTDISABLE = 1 << 1,

      /// <summary>
      /// The home directory is required.
      ///</summary>
      HOMEDIR_REQUIRED = 1 << 3,

      /// <summary>
      /// The account is currently locked out.
      ///</summary>
      LOCKOUT = 1 << 4,

      /// <summary>
      /// No password is required.
      ///</summary>
      PASSWD_NOTREQD = 1 << 5,

      /// <summary>
      /// The user cannot change the password.
      ///</summary>
      /// <remarks>
      /// Note:  You cannot assign the permission settings of PASSWD_CANT_CHANGE by directly modifying the UserAccountControl attribute.
      /// For more information and a code example that shows how to prevent a user from changing the password, see User Cannot Change Password.
      /// </remarks>
      PASSWD_CANT_CHANGE = 1 << 6,

      /// <summary>
      /// The user can send an encrypted password.
      ///</summary>
      ENCRYPTED_TEXT_PASSWORD_ALLOWED = 1 << 7,

      /// <summary>
      /// This is an account for users whose primary account is in another domain. This account provides user access to this domain, but not
      /// to any domain that trusts this domain. Also known as a local user account.
      ///</summary>
      TEMP_DUPLICATE_ACCOUNT = 1 << 8,

      /// <summary>
      /// This is a default account type that represents a typical user.
      ///</summary>
      NORMAL_ACCOUNT = 1 << 9,

      /// <summary>
      /// This is a permit to trust account for a system domain that trusts other domains.
      ///</summary>
      INTERDOMAIN_TRUST_ACCOUNT = 1 << 11,

      /// <summary>
      /// This is a computer account for a computer that is a member of this domain.
      ///</summary>
      WORKSTATION_TRUST_ACCOUNT = 1 << 12,

      /// <summary>
      /// This is a computer account for a system backup domain controller that is a member of this domain.
      ///</summary>
      SERVER_TRUST_ACCOUNT = 1 << 13,

      Unused1 = 1 << 14,

      Unused2 = 1 << 15,

      /// <summary>
      /// The password for this account will never expire.
      ///</summary>
      DONT_EXPIRE_PASSWD = 1 << 16,

      /// <summary>
      /// This is an MNS logon account.
      ///</summary>
      MNS_LOGON_ACCOUNT = 1 << 17,

      /// <summary>
      /// The user must log on using a smart card.
      ///</summary>
      SMARTCARD_REQUIRED = 1 << 18,

      /// <summary>
      /// The service account (user or computer account), under which a service runs, is trusted for Kerberos delegation. Any such service
      /// can impersonate a client requesting the service.
      ///</summary>
      TRUSTED_FOR_DELEGATION = 1 << 19,

      /// <summary>
      /// The security context of the user will not be delegated to a service even if the service account is set as trusted for Kerberos delegation.
      ///</summary>
      NOT_DELEGATED = 1 << 20,

      /// <summary>
      /// Restrict this principal to use only Data Encryption Standard (DES) encryption types for keys.
      ///</summary>
      USE_DES_KEY_ONLY = 1 << 21,

      /// <summary>
      /// This account does not require Kerberos pre-authentication for logon.
      ///</summary>
      DONT_REQUIRE_PREAUTH = 1 << 22,

      /// <summary>
      /// The user password has expired. This flag is created by the system using data from the Pwd-Last-Set attribute and the domain policy.
      ///</summary>
      PASSWORD_EXPIRED = 1 << 23,

      /// <summary>
      /// The account is enabled for delegation. This is a security-sensitive setting; accounts with this option enabled should be strictly
      /// controlled. This setting enables a service running under the account to assume a client identity and authenticate as that user to
      /// other remote servers on the network.
      ///</summary>
      TRUSTED_TO_AUTHENTICATE_FOR_DELEGATION = 1 << 24,

      PARTIAL_SECRETS_ACCOUNT = 1 << 26,

      USE_AES_KEYS = 1 << 27
   }
}
