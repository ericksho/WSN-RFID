class CreateAlerta < ActiveRecord::Migration
  def change
    create_table :alerta do |t|
      t.boolean :desconectada

      t.timestamps
    end
  end
end
