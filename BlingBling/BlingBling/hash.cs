using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Security.Cryptography;

namespace BlingBling
{
  class passhasher
  {
    static SHA512Managed shaM = new SHA512Managed();
    

    public string GetSHA512Hash(string input)
    {
      return GetSHA512Hash(shaM, input);
    }

    public bool VerifySHA512Hash(string input, string hash)
    {
      return VerifySHA512Hash(shaM, input, hash);
    }

    static string GetSHA512Hash(SHA512 sha512Hash, string input)
    {

      // Convert the input string to a byte array and compute the hash. 
      byte[] data = sha512Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

      // Create a new Stringbuilder to collect the bytes 
      // and create a string.
      StringBuilder sBuilder = new StringBuilder();

      // Loop through each byte of the hashed data  
      // and format each one as a hexadecimal string. 
      for (int i = 0; i < data.Length; i++)
      {
        sBuilder.Append(data[i].ToString("x2"));
      }

      // Return the hexadecimal string. 
      return sBuilder.ToString();
    }

    // Verify a hash against a string. 
    static bool VerifySHA512Hash(SHA512 sha512Hash, string input, string hash)
    {
      // Hash the input. 
      string hashOfInput = GetSHA512Hash(sha512Hash, input);

      // Create a StringComparer an compare the hashes.
      StringComparer comparer = StringComparer.OrdinalIgnoreCase;

      if (0 == comparer.Compare(hashOfInput, hash))
      {
        return true;
      }
      else
      {
        return false;
      }
    }
  }
}
