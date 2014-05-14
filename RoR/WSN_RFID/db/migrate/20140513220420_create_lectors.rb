class CreateLectors < ActiveRecord::Migration
  def change
    create_table :lectors do |t|
      t.string :posicion

      t.timestamps
    end
  end
end
