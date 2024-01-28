import fs from 'fs';
import { glob } from 'glob'

glob('**/sample.*settings.json', { ignore: '**/bin/**' })
    .then(sampleSettingsFilenames => {
        for (const sampleSettingsFilename of sampleSettingsFilenames)
        {
            const settingsFilename = sampleSettingsFilename.replace('sample.', '');            
            const fileExists = fs.existsSync(settingsFilename);
            
            if (fileExists) {
                console.log(`Settings file: ${settingsFilename} already exists.  Skipping.`);
            } else {
                console.log(`Copying ${sampleSettingsFilename} to ${settingsFilename}.`);
                fs.copyFileSync(sampleSettingsFilename, settingsFilename, fs.constants.COPYFILE_EXCL);
            }
        }        
    });
