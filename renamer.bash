# Script to rename all Plugin.cs files to RadialMenuPlugin.cs
# Searches current directory and all subdirectories recursively

echo "Searching for Plugin.cs files..."

# Find all files named exactly "Plugin.cs" and rename them
find . -type f -name "RadialMenuPlugin.cs" | while read -r file; do
    # Get the directory of the file
    dir=$(dirname "$file")
    
    # Create the new filename
    newfile="$dir/Plugin.cs"
    
    # Check if the target file already exists
    if [ -f "$newfile" ]; then
        echo "Warning: $newfile already exists - skipping $file"
    else
        # Rename the file
        mv "$file" "$newfile"
        echo "Renamed: $file -> $newfile"
    fi
done

echo "Done!"