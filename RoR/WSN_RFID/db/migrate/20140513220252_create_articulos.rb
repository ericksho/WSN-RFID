class CreateArticulos < ActiveRecord::Migration
  def change
    create_table :articulos do |t|
      t.integer :rfid
      t.boolean :estado

      t.timestamps
    end
  end
end
