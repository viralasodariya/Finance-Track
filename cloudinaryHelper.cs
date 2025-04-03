using System;
using System.Drawing;
using System.IO;
using CloudinaryDotNet;
using CloudinaryDotNet.Actions;

public static class CloudinaryHelper
{
    private static Cloudinary cloudinary;

    // Static constructor to initialize Cloudinary
    static CloudinaryHelper()
    {
        Account account = new Account(
            "dvjza1onp", "296616889666346", "JMX1CrutZ6Rome2ARnLGWxO_SsQ"
        );
        cloudinary = new Cloudinary(account);
        cloudinary.Api.Secure = true;
    }

    public static string UploadImageToCloudinary(string imagePath)
    {
        try
        {
            var uploadParams = new ImageUploadParams()
            {
                File = new FileDescription(imagePath),
                Folder = "project",
                Transformation = new Transformation().Crop("fill").Gravity("face").Width(200).Height(200) // Optional resizing
            };

            var uploadResult = cloudinary.Upload(uploadParams);

            if (uploadResult.StatusCode == System.Net.HttpStatusCode.OK)
            {
                MessageBox.Show("Image uploaded successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return uploadResult.SecureUrl.ToString(); // ✅ Ensure return on success
            }
            else
            {
                MessageBox.Show("Image upload failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return string.Empty; // ✅ Return an empty string if upload fails
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Cloudinary upload error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return string.Empty; // ✅ Ensure return value in case of an exception
        }
    }
}
