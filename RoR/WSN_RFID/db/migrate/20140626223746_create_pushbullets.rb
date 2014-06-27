class CreatePushbullets < ActiveRecord::Migration
  def change
    create_table :pushbullets do |t|
      t.string :token
      t.string :email
      t.string :motivo

      t.timestamps
    end
  end
end
