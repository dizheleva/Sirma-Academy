function decrypt(input) {
    const fileName = input.substring(input.lastIndexOf('\\') + 1, input.lastIndexOf('.'));
    const fileExtension = input.substring(input.lastIndexOf('.') + 1);
    
    console.log(`File name: ${fileName}`);
    console.log(`File extension: ${fileExtension}`);
}

decrypt('C:\\desktop\\academy\\template.pptx');
decrypt('C:\\Projects\\website.folder\\file.name.js');